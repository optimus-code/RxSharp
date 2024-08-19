using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Event" )]
    public class Event
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "x" )]
        public int X { get; set; }

        [RmName( "y" )]
        public int Y { get; set; }

        [RmName( "pages" )]
        public List<EventPage> Pages { get; set; } = new List<EventPage> { new EventPage( ) };

        public Event( )
        {
        }

        public Event( int x, int y )
        {
            X = x;
            Y = y;
        }
    }
}