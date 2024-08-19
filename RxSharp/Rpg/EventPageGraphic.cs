using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Event::Page:Graphic" )]
    public class EventPageGraphic
    {
        [RmName( "tile_id" )]
        public int TileID { get; set; } = 0;

        [RmName( "character_name" )]
        public string CharacterName { get; set; } = "";

        [RmName( "character_hue" )]
        public int CharacterHue { get; set; } = 0;

        [RmName( "direction" )]
        public int Direction { get; set; } = 2;

        [RmName( "pattern" )]
        public int Pattern { get; set; } = 0;

        [RmName( "opacity" )]
        public int Opacity { get; set; } = 255;

        [RmName( "blend_type" )]
        public int BlendType { get; set; } = 0;
    }
}