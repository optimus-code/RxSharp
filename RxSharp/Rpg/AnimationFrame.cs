using RmSharp.Attributes;
using RxSharp.Converters;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Animation::Frame" )]
    public class AnimationFrame
    {
        [RmName( "cell_max" )]
        public int CellMax { get; set; } = 0;

        [RmName( "cell_data" )]
        [RmBuffer<TableConverter>( "Table" )]
        public List<List<short>> CellData { get; set; }
    }
}