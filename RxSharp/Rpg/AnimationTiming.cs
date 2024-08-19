using RmSharp.Attributes;
using System.Drawing;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Animation::Timing" )]
    public class AnimationTiming
    {
        [RmName( "frame" )]
        public int Frame { get; set; } = 0;

        [RmName( "se" )]
        public AudioFile SE { get; set; } = new AudioFile( "", 80 );

        [RmName( "flash_scope" )]
        public int FlashScope { get; set; } = 0;

        [RmName( "flash_color" )]
        public Color FlashColor { get; set; } = Color.FromArgb( 255, 255, 255, 255 );

        [RmName( "flash_duration" )]
        public int FlashDuration { get; set; } = 5;

        [RmName( "condition" )]
        public int Condition { get; set; } = 0;
    }
}
