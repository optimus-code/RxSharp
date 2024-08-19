using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Troop::Page" )]
    public class TroopPage
    {
        [RmName( "condition" )]
        public TroopPageCondition Condition { get; set; } = new TroopPageCondition( );

        [RmName( "span" )]
        public int Span { get; set; } = 0;

        [RmName( "list" )]
        public List<EventCommand> List { get; set; } = new List<EventCommand> { new EventCommand( ) };
    }
}