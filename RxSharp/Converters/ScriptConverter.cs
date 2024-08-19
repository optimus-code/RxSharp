using RmSharp.Extensions;
using RmSharp.Tokens;
using RxSharp.Rpg;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace RxSharp.Converters
{
    public class ScriptConverter
    {
        public List<Script> Read( BinaryReader reader )
        {
            reader.ReadByte( );
            reader.ReadByte( );

            var token = reader.ReadToken( RubyMarshalToken.Array );
            var scriptCount = reader.ReadFixNum<int>( );

            var results = new List<Script>( );

            for ( var i = 0; i < scriptCount; i++ )
            {
                var scriptArrayToken = reader.ReadToken( RubyMarshalToken.Array );
                var scriptItemCount = reader.ReadFixNum<int>( );
                var magicNumber = reader.ReadNumeric<int>( );

                var scriptName = reader.ReadRubyString( );

                var scriptToken = reader.ReadToken( RubyMarshalToken.String );
                var scriptLength = reader.ReadFixNum<int>( );
                var scriptCode = reader.ReadBytes( scriptLength );

                results.Add( new Script
                {
                    MagicNumber = magicNumber,
                    Name = scriptName,
                    Code = Decompress( scriptCode )
                } );
            }

            return results;
        }

        public void Write( BinaryWriter writer, List<Script> scripts )
        {
            writer.Write( ( byte ) 4 );
            writer.Write( ( byte ) 8 );

            writer.Write( RubyMarshalToken.Array );
            writer.WriteFixNum( scripts.Count );

            foreach ( var script in scripts )
            {
                writer.Write( RubyMarshalToken.Array );
                writer.WriteFixNum( 3 );

                writer.WriteNumeric( script.MagicNumber );

                writer.WriteRubyString( script.Name );

                if ( script.Code == null )
                {
                    writer.Write( RubyMarshalToken.Nil );
                }
                else
                {
                    var compressedCode = Compress( script.Code );

                    writer.Write( RubyMarshalToken.String );
                    writer.WriteFixNum( compressedCode.Length );
                    writer.Write( compressedCode );
                }
            }
        }

        private string Decompress( byte[] buffer )
        {
            using ( var compressedStream = new MemoryStream( buffer ) )
            using ( var zlibStream = new ZLibStream( compressedStream, CompressionMode.Decompress ) )
            using ( var resultStream = new MemoryStream( ) )
            {
                zlibStream.CopyTo( resultStream );

                var uncompressedBuffer = resultStream.ToArray( );

                return Encoding.UTF8.GetString( uncompressedBuffer );
            }
        }

        private byte[] Compress( string scriptCode )
        {
            var uncompressedBuffer = Encoding.UTF8.GetBytes( scriptCode );

            using ( var resultStream = new MemoryStream( ) )
            {
                using ( var zlibStream = new ZLibStream( resultStream, CompressionMode.Compress ) )
                {
                    zlibStream.Write( uncompressedBuffer, 0, uncompressedBuffer.Length );
                }

                return resultStream.ToArray( );
            }
        }
    }
}