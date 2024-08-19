using RmSharp;
using System.Collections.Generic;
using System.IO;

namespace RxSharp.Extensions
{
    public static class DataExtensions
    {
        public static List<T> Load<T>( string file )
            where T : IListFile
        {
            using ( var stream = File.OpenRead( file ) )
            {
                return RmSerialiser.Deserialise<List<T>>( stream );
            }
        }

        public static void Save<T>( string file, List<T> instance )
            where T : IListFile
        {
            using ( var stream = File.Create( file ) )
            {
                RmSerialiser.Serialise( stream, instance );
            }
        }
    }
}