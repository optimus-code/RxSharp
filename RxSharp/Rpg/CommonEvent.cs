using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::CommonEvent" )]
    public class CommonEvent : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "trigger" )]
        public int Trigger { get; set; } = 0;

        [RmName( "switch_id" )]
        public int SwitchID { get; set; } = 1;

        [RmName( "list" )]
        public List<EventCommand> List { get; set; } = new List<EventCommand> { new EventCommand( ) };
    }
}