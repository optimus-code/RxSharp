using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Tileset" )]
    public class Tileset : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "tileset_name" )]
        public string TilesetName { get; set; } = "";

        [RmName( "autotile_names" )]
        public string[] AutotileNames { get; set; } = new string[7];

        [RmName( "panorama_name" )]
        public string PanoramaName { get; set; } = "";

        [RmName( "panorama_hue" )]
        public int PanoramaHue { get; set; } = 0;

        [RmName( "fog_name" )]
        public string FogName { get; set; } = "";

        [RmName( "fog_hue" )]
        public int FogHue { get; set; } = 0;

        [RmName( "fog_opacity" )]
        public int FogOpacity { get; set; } = 64;

        [RmName( "fog_blend_type" )]
        public int FogBlendType { get; set; } = 0;

        [RmName( "fog_zoom" )]
        public int FogZoom { get; set; } = 200;

        [RmName( "fog_sx" )]
        public int FogSX { get; set; } = 0;

        [RmName( "fog_sy" )]
        public int FogSY { get; set; } = 0;

        [RmName( "battleback_name" )]
        public string BattlebackName { get; set; } = "";

        [RmName( "passages" )]
        public int[] Passages { get; set; } = new int[384];

        [RmName( "priorities" )]
        public int[] Priorities { get; set; } = new int[384];

        [RmName( "terrain_tags" )]
        public int[] TerrainTags { get; set; } = new int[384];

        public Tileset( )
        {
            Priorities[0] = 5;
        }
    }
}