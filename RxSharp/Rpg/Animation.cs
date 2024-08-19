using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Animation" )]
    public class Animation : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "animation_name" )]
        public string AnimationName { get; set; } = "";

        [RmName( "animation_hue" )]
        public int AnimationHue { get; set; } = 0;

        [RmName( "position" )]
        public int Position { get; set; } = 1;

        [RmName( "frame_max" )]
        public int FrameMax { get; set; } = 1;

        [RmName( "frames" )]
        public List<AnimationFrame> Frames { get; set; } = new List<AnimationFrame> { new AnimationFrame( ) };

        [RmName( "timings" )]
        public List<AnimationTiming> Timings { get; set; } = new List<AnimationTiming>( );
    }
}