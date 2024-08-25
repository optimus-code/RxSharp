using RmSharp.Attributes;
using RxSharp.Converters;
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
        [RmBuffer<TableConverter>( "Table" )]
        public List<short> ElementRanks { get; set; } = [0];

        [RmName( "state_ranks" )]
        [RmBuffer<TableConverter>( "Table" )]
        public List<short> StateRanks { get; set; } = [0];

        [RmName( "learnings" )]
        public List<ClassLearning> Learnings { get; set; } = new List<ClassLearning>( );
    }
}