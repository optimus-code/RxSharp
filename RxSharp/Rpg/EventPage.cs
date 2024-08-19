using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Event::Page" )]
    public class EventPage
    {
        [RmName( "condition" )]
        public EventPageCondition Condition { get; set; } = new EventPageCondition( );

        [RmName( "graphic" )]
        public EventPageGraphic Graphic { get; set; } = new EventPageGraphic( );

        [RmName( "move_type" )]
        public int MoveType { get; set; } = 0;

        [RmName( "move_speed" )]
        public int MoveSpeed { get; set; } = 3;

        [RmName( "move_frequency" )]
        public int MoveFrequency { get; set; } = 3;

        [RmName( "move_route" )]
        public MoveRoute MoveRoute { get; set; } = new MoveRoute( );

        [RmName( "walk_anime" )]
        public bool WalkAnime { get; set; } = true;

        [RmName( "step_anime" )]
        public bool StepAnime { get; set; } = false;

        [RmName( "direction_fix" )]
        public bool DirectionFix { get; set; } = false;

        [RmName( "through" )]
        public bool Through { get; set; } = false;

        [RmName( "always_on_top" )]
        public bool AlwaysOnTop { get; set; } = false;

        [RmName( "trigger" )]
        public int Trigger { get; set; } = 0;

        [RmName( "list" )]
        public List<EventCommand> List { get; set; } = new List<EventCommand> { new EventCommand( ) };
    }
}