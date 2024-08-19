using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Weapon" )]
    public class Weapon : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "icon_name" )]
        public string IconName { get; set; } = "";

        [RmName( "description" )]
        public string Description { get; set; } = "";

        [RmName( "animation1_id" )]
        public int Animation1ID { get; set; } = 0;

        [RmName( "animation2_id" )]
        public int Animation2ID { get; set; } = 0;

        [RmName( "price" )]
        public int Price { get; set; } = 0;

        [RmName( "atk" )]
        public int Atk { get; set; } = 0;

        [RmName( "pdef" )]
        public int PDef { get; set; } = 0;

        [RmName( "mdef" )]
        public int MDef { get; set; } = 0;

        [RmName( "str_plus" )]
        public int StrPlus { get; set; } = 0;

        [RmName( "dex_plus" )]
        public int DexPlus { get; set; } = 0;

        [RmName( "agi_plus" )]
        public int AgiPlus { get; set; } = 0;

        [RmName( "int_plus" )]
        public int IntPlus { get; set; } = 0;

        [RmName( "element_set" )]
        public List<int> ElementSet { get; set; } = new List<int>( );

        [RmName( "plus_state_set" )]
        public List<int> PlusStateSet { get; set; } = new List<int>( );

        [RmName( "minus_state_set" )]
        public List<int> MinusStateSet { get; set; } = new List<int>( );
    }
}