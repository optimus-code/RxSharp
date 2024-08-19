using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::MoveRoute" )]
    public class MoveRoute
    {
        [RmName( "repeat" )]
        public bool Repeat { get; set; } = true;

        [RmName( "skippable" )]
        public bool Skippable { get; set; } = false;

        [RmName( "list" )]
        public List<MoveCommand> List { get; set; } = new List<MoveCommand> { new MoveCommand( ) };
    }
}