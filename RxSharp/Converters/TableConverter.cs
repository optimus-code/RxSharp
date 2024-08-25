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
            int dim = reader.ReadInt32( );
            int x = reader.ReadInt32( );
            int y = reader.ReadInt32( );
            int z = reader.ReadInt32( );
            int size = reader.ReadInt32( );

            if ( size != x * y * z )
                throw new InvalidDataException( "Bad file format: size mismatch" );

            if ( dim == 3 )
            {
                var table = new List<List<List<short>>>( );
                for ( int i = 0; i < x; i++ )
                {
                    var yList = new List<List<short>>( );
                    for ( int j = 0; j < y; j++ )
                    {
                        var zList = new List<short>( );
                        for ( int k = 0; k < z; k++ )
                        {
                            zList.Add( reader.ReadInt16( ) );
                        }
                        yList.Add( zList );
                    }
                    table.Add( yList );
                }
                return table;
            }
            else if ( dim == 2 )
            {
                var table = new List<List<short>>( );
                for ( int i = 0; i < x; i++ )
                {
                    var yList = new List<short>( );
                    for ( int j = 0; j < y; j++ )
                    {
                        yList.Add( reader.ReadInt16( ) );
                    }
                    table.Add( yList );
                }
                return table;
            }
            else if ( dim == 1 )
            {
                var table = new List<short>( );
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
                int x = table3D.Count;
                int y = ( x > 0 ) ? table3D[0].Count : 0;
                int z = ( y > 0 ) ? table3D[0][0].Count : 0;
                int size = x * y * z;

                // Write dimensions
                writer.Write( 3 );  // Dimension is 3
                writer.Write( x );
                writer.Write( y );
                writer.Write( z );
                writer.Write( size );

                // Write data
                foreach ( var yList in table3D )
                {
                    foreach ( var zList in yList )
                    {
                        foreach ( var value in zList )
                        {
                            writer.Write( value );
                        }
                    }
                }
            }
            else if ( instance is List<List<short>> table2D )
            {
                int x = table2D.Count;
                int y = ( x > 0 ) ? table2D[0].Count : 0;
                int size = x * y;

                // Write dimensions
                writer.Write( 2 );  // Dimension is 2
                writer.Write( x );
                writer.Write( y );
                writer.Write( 1 );  // z is set to 1 for 2D
                writer.Write( size );

                // Write data
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

                // Write dimensions
                writer.Write( 1 );  // Dimension is 1
                writer.Write( x );
                writer.Write( 1 );  // y is set to 1 for 1D
                writer.Write( 1 );  // z is set to 1 for 1D
                writer.Write( size );

                // Write data
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
