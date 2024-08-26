using RmSharp;
using RxSharp.Rpg;
using System.Collections.Generic;
using System.IO;

namespace RxSharp
{
    public static class RxData
    {
        public static RpgSystem LoadSystem( string file )
        {
            return LoadSingle<RpgSystem>( file );
        }

        public static void Save( string file, RpgSystem instance )
        {
            SaveSingle( file, instance );
        }

        public static Dictionary<int, MapInfo> LoadMapInfos( string file )
        {
            return LoadDictionary<MapInfo>( file );
        }

        public static void Save( string file, Dictionary<int, MapInfo> instance )
        {
            SaveDictionary( file, instance );
        }

        public static Map LoadMap( string file )
        {
            return LoadSingle<Map>( file );
        }

        public static void Save( string file, Map instance )
        {
            SaveSingle( file, instance );
        }

        public static List<Actor> LoadActors( string file )
        {
            return LoadList<Actor>( file );
        }

        public static void Save( string file, List<Actor> instance )
        {
            SaveList( file, instance );
        }

        public static List<Animation> LoadAnimations( string file )
        {
            return LoadList<Animation>( file );
        }

        public static void Save( string file, List<Animation> instance )
        {
            SaveList( file, instance );
        }

        private static List<Armor> LoadArmors( string file )
        {
            return LoadList<Armor>( file );
        }

        public static void Save( string file, List<Armor> instance )
        {
            SaveList( file, instance );
        }

        public static List<Class> LoadClasses( string file )
        {
            return LoadList<Class>( file );
        }

        public static void Save( string file, List<Class> instance )
        {
            SaveList( file, instance );
        }

        public static List<CommonEvent> LoadCommonEvents( string file )
        {
            return LoadList<CommonEvent>( file );
        }

        public static void Save( string file, List<CommonEvent> instance )
        {
            SaveList( file, instance );
        }

        public static List<Enemy> LoadEnemies( string file )
        {
            return LoadList<Enemy>( file );
        }

        public static void Save( string file, List<Enemy> instance )
        {
            SaveList( file, instance );
        }

        public static List<Item> LoadItems( string file )
        {
            return LoadList<Item>( file );
        }

        public static void Save( string file, List<Item> instance )
        {
            SaveList( file, instance );
        }

        public static List<Script> LoadScripts( string file )
        {
            return LoadList<Script>( file );
        }

        public static void Save( string file, List<Script> instance )
        {
            SaveList( file, instance );
        }

        public static List<Skill> LoadSkills( string file )
        {
            return LoadList<Skill>( file );
        }

        public static void Save( string file, List<Skill> instance )
        {
            SaveList( file, instance );
        }

        public static List<State> LoadStates( string file )
        {
            return LoadList<State>( file );
        }

        public static void Save( string file, List<State> instance )
        {
            SaveList( file, instance );
        }

        public static List<Tileset> LoadTilesets( string file )
        {
            return LoadList<Tileset>( file );
        }

        public static void Save( string file, List<Tileset> instance )
        {
            SaveList( file, instance );
        }

        public static List<Troop> LoadTroops( string file )
        {
            return LoadList<Troop>( file );
        }

        public static void Save( string file, List<Troop> instance )
        {
            SaveList( file, instance );
        }

        public static List<Weapon> LoadWeapons( string file )
        {
            return LoadList<Weapon>( file );
        }

        public static void Save( string file, List<Weapon> instance )
        {
            SaveList( file, instance );
        }

        private static T LoadSingle<T>( string file )
            where T : ISingleInstanceFile
        {
            using ( var stream = File.OpenRead( file ) )
            {
                return RmSerialiser.Deserialise<T>( stream );
            }
        }

        private static void SaveSingle<T>( string file, T instance )
        {
            using ( var stream = File.Create( file ) )
            {
                RmSerialiser.Serialise( stream, instance );
            }
        }

        private static List<T> LoadList<T>( string file )
            where T : IListFile
        {
            using ( var stream = File.OpenRead( file ) )
            {
                return RmSerialiser.Deserialise<List<T>>( stream );
            }
        }

        private static void SaveList<T>( string file, List<T> instance )
            where T : IListFile
        {
            using ( var stream = File.Create( file ) )
            {
                RmSerialiser.Serialise( stream, instance );
            }
        }

        private static Dictionary<int, T> LoadDictionary<T>( string file )
            where T : IDictionaryFile
        {
            using ( var stream = File.OpenRead( file ) )
            {
                return RmSerialiser.Deserialise<Dictionary<int, T>>( stream );
            }
        }

        private static void SaveDictionary<T>( string file, Dictionary<int, T> instance )
            where T : IDictionaryFile
        {
            using ( var stream = File.Create( file ) )
            {
                RmSerialiser.Serialise( stream, instance );
            }
        }
    }
}