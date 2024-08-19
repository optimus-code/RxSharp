using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::EventCommand" )]
    public class EventCommand
    {
        [RmName( "code" )]
        public int Code { get; set; } = 0;

        [RmName( "indent" )]
        public int Indent { get; set; } = 0;

        [RmName( "parameters" )]
        public List<dynamic> Parameters { get; set; } = new List<dynamic>( );

        public EventCommand( )
        {
        }

        public EventCommand( int code = 0, int indent = 0, List<dynamic> parameters = null )
        {
            Code = code;
            Indent = indent;
            Parameters = parameters ?? new List<dynamic>( );
        }
    }
}