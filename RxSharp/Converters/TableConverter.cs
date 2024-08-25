using RmSharp.Converters;
using System;
using System.Collections.Generic;
using System.IO;

namespace RxSharp.Converters
{
    public class TableConverter : RmConverter
    {
        public override object Read( BinaryReader reader )
        {
            // Read dimensions
            int dim = reader.ReadInt32( ); // Dimension (should be 3)
            int x = reader.ReadInt32( );   // Width
            int y = reader.ReadInt32( );   // Height
            int z = reader.ReadInt32( );   // Layer count
            int size = reader.ReadInt32( ); // Total size (should be x * y * z)

            if ( size != x * y * z )
                throw new InvalidDataException( "Bad file format: size mismatch" );

            if ( dim == 3 )
            {
                // Start with the outermost loop for z (layers)
                var table = new List<List<List<short>>>( z );
                for ( int k = 0; k < z; k++ )
                {
                    var yList = new List<List<short>>( y );
                    for ( int j = 0; j < y; j++ )
                    {
                        var xList = new List<short>( x );
                        for ( int i = 0; i < x; i++ )
                        {
                            xList.Add( reader.ReadInt16( ) );
                        }
                        yList.Add( xList );
                    }
                    table.Add( yList );
                }
                return table;
            }
            else if ( dim == 2 )
            {
                // For 2D, Y is the outermost loop, followed by X
                var table = new List<List<short>>( y );
                for ( int j = 0; j < y; j++ )
                {
                    var xList = new List<short>( x );
                    for ( int i = 0; i < x; i++ )
                    {
                        xList.Add( reader.ReadInt16( ) );
                    }
                    table.Add( xList );
                }
                return table;
            }
            else if ( dim == 1 )
            {
                // For 1D, simply add X elements
                var table = new List<short>( x );
                for ( int i = 0; i < x; i++ )
                {
                    table.Add( reader.ReadInt16( ) );
                }
                return table;
            }
            else
            {
                throw new InvalidDataException( $"Unsupported dimension: {dim}" );
            }
        }

        public override void Write( BinaryWriter writer, object instance )
        {
            if ( instance is List<List<List<short>>> table3D )
            {
                int z = table3D.Count;
                int y = ( z > 0 ) ? table3D[0].Count : 0;
                int x = ( y > 0 ) ? table3D[0][0].Count : 0;
                int size = x * y * z;

                // Write dimensions
                writer.Write( 3 );
                writer.Write( x );
                writer.Write( y );
                writer.Write( z );
                writer.Write( size );

                foreach ( var zList in table3D )
                {
                    foreach ( var yList in zList )
                    {
                        foreach ( var value in yList )
                        {
                            writer.Write( value );
                        }
                    }
                }
            }
            else if ( instance is List<List<short>> table2D )
            {
                int y = table2D.Count; 
                int x = ( y > 0 ) ? table2D[0].Count : 0;
                int size = x * y;

                writer.Write( 2 );
                writer.Write( x );
                writer.Write( y );
                writer.Write( 1 );
                writer.Write( size );

                foreach ( var yList in table2D )
                {
                    foreach ( var value in yList )
                    {
                        writer.Write( value );
                    }
                }
            }
            else if ( instance is List<short> table1D )
            {
                int x = table1D.Count;
                int size = x;

                writer.Write( 1 );
                writer.Write( x );
                writer.Write( 1 );
                writer.Write( 1 );
                writer.Write( size );

                foreach ( var value in table1D )
                {
                    writer.Write( value );
                }
            }
            else
            {
                throw new InvalidCastException( "Instance is not a valid table" );
            }
        }
    }
}
