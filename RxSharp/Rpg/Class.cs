using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Class" )]
    public class Class : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "position" )]
        public int Position { get; set; } = 0;

        [RmName( "weapon_set" )]
        public List<int> WeaponSet { get; set; } = new List<int>( );

        [RmName( "armor_set" )]
        public List<int> ArmorSet { get; set; } = new List<int>( );

        [RmName( "element_ranks" )]
        public int[] ElementRanks { get; set; } = new int[1];

        [RmName( "state_ranks" )]
        public int[] StateRanks { get; set; } = new int[1];

        [RmName( "learnings" )]
        public List<ClassLearning> Learnings { get; set; } = new List<ClassLearning>( );
    }
}