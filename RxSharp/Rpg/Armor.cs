using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Armor" )]
    public class Armor : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "icon_name" )]
        public string IconName { get; set; } = "";

        [RmName( "description" )]
        public string Description { get; set; } = "";

        [RmName( "kind" )]
        public int Kind { get; set; } = 0;

        [RmName( "auto_state_id" )]
        public int AutoStateID { get; set; } = 0;

        [RmName( "price" )]
        public int Price { get; set; } = 0;

        [RmName( "pdef" )]
        public int PDef { get; set; } = 0;

        [RmName( "mdef" )]
        public int MDef { get; set; } = 0;

        [RmName( "eva" )]
        public int Eva { get; set; } = 0;

        [RmName( "str_plus" )]
        public int StrPlus { get; set; } = 0;

        [RmName( "dex_plus" )]
        public int DexPlus { get; set; } = 0;

        [RmName( "agi_plus" )]
        public int AgiPlus { get; set; } = 0;

        [RmName( "int_plus" )]
        public int IntPlus { get; set; } = 0;

        [RmName( "guard_element_set" )]
        public List<int> GuardElementSet { get; set; } = new List<int>( );

        [RmName( "guard_state_set" )]
        public List<int> GuardStateSet { get; set; } = new List<int>( );
    }
}