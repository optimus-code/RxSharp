using RmSharp.Converters;
using RmSharp.Extensions;
using RmSharp.Tokens;
using RxSharp.Rpg;
using System;
using System.Collections.Generic;
using System.IO;

namespace RxSharp.Converters
{
    public class ColorConverter : RmConverter
    {
        private readonly SymbolConverter _symbolConverter = RmConverterFactory.SymbolConverter;

        public override object Read( BinaryReader reader )
        {
            var token = reader.ReadToken( RubyMarshalToken.UserDefined );
            var name = ( string ) _symbolConverter.Read( reader );
            var size = reader.ReadFixNum<int>( );

            var red = reader.ReadDouble( );
            var green = reader.ReadDouble( );
            var blue = reader.ReadDouble( );
            var alpha = reader.ReadDouble( );

            return new Color
            {
                Red = ( byte ) red,
                Green = ( byte ) green,
                Blue = ( byte ) blue,
                Alpha = ( byte ) alpha,
            };
        }

        public override void Write( BinaryWriter writer, object instance )
        {
            writer.Write( RubyMarshalToken.UserDefined );
            _symbolConverter.Write( writer, "Color" );

            writer.WriteFixNum( 32 );

            var color = ( Color ) instance;
            writer.Write( ( double ) color.Red );
            writer.Write( ( double ) color.Green );
            writer.Write( ( double ) color.Blue );
            writer.Write( ( double ) color.Alpha );
        }
    }
}