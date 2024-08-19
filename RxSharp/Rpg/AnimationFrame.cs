using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Animation::Frame" )]
    public class AnimationFrame
    {
        [RmName( "cell_max" )]
        public int CellMax { get; set; } = 0;

        [RmName( "cell_data" )]
        public int[,] CellData { get; set; } = new int[0, 0];
    }
}