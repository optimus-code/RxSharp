using System;
using System.Runtime.InteropServices;

namespace RxSharp.Rpg
{
    [StructLayout( LayoutKind.Sequential )]
    public struct Color
    {
        public byte Red
        {
            get;
            set;
        }
        public byte Green
        {
            get;
            set;
        }
        public byte Blue
        {
            get;
            set;
        }
        public byte Alpha
        {
            get;
            set;
        }

        public override bool Equals( object obj )
        {
            if ( !( obj is Color ) )
            {
                return false;
            }

            Color other = ( Color ) obj;
            return Red == other.Red &&
                   Green == other.Green &&
                   Blue == other.Blue &&
                   Alpha == other.Alpha;
        }

        public override int GetHashCode( )
        {
            return HashCode.Combine( Red, Green, Blue, Alpha );
        }

        public static bool operator ==( Color left, Color right )
        {
            return left.Equals( right );
        }

        public static bool operator !=( Color left, Color right )
        {
            return !( left == right );
        }

        public static Color FromArgb( byte alpha, byte red, byte green, byte blue )
        {
            return new Color
            {
                Red = red,
                Green = green,
                Blue = blue,
                Alpha = alpha
            };
        }
    }
}