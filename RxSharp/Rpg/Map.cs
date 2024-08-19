using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Map" )]
    public class Map
    {
        [RmName( "tileset_id" )]
        public int TilesetID { get; set; } = 1;

        [RmName( "width" )]
        public int Width { get; set; }

        [RmName( "height" )]
        public int Height { get; set; }

        [RmName( "autoplay_bgm" )]
        public bool AutoplayBgm { get; set; } = false;

        [RmName( "bgm" )]
        public AudioFile Bgm { get; set; } = new AudioFile( );

        [RmName( "autoplay_bgs" )]
        public bool AutoplayBgs { get; set; } = false;

        [RmName( "bgs" )]
        public AudioFile Bgs { get; set; } = new AudioFile( "", 80 );

        [RmName( "encounter_list" )]
        public List<int> EncounterList { get; set; } = new List<int>( );

        [RmName( "encounter_step" )]
        public int EncounterStep { get; set; } = 30;

        [RmName( "data" )]
        public int[,,] Data { get; set; }

        [RmName( "events" )]
        public Dictionary<int, Event> Events { get; set; } = new Dictionary<int, Event>( );

        public Map( int width, int height )
        {
            Width = width;
            Height = height;
            Data = new int[width, height, 3];
        }
    }
}