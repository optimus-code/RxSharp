using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::MoveCommand" )]
    public class MoveCommand
    {
        [RmName( "code" )]
        public int Code { get; set; } = 0;

        [RmName( "parameters" )]
        public List<object> Parameters { get; set; } = new List<object>( );

        public MoveCommand( int code = 0, List<object> parameters = null )
        {
            Code = code;
            Parameters = parameters ?? new List<object>( );
        }
    }
}