using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Troop" )]
    public class Troop : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "members" )]
        public List<TroopMember> Members { get; set; } = new List<TroopMember>( );

        [RmName( "pages" )]
        public List<TroopPage> Pages { get; set; } = new List<TroopPage> { new TroopPage( ) };
    }
}