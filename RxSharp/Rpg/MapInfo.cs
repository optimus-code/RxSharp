using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::MapInfo" )]
    public class MapInfo
    {
        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "parent_id" )]
        public int ParentID { get; set; } = 0;

        [RmName( "order" )]
        public int Order { get; set; } = 0;

        [RmName( "expanded" )]
        public bool Expanded { get; set; } = false;

        [RmName( "scroll_x" )]
        public int ScrollX { get; set; } = 0;

        [RmName( "scroll_y" )]
        public int ScrollY { get; set; } = 0;
    }
}