using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Item" )]
    public class Item : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "icon_name" )]
        public string IconName { get; set; } = "";

        [RmName( "description" )]
        public string Description { get; set; } = "";

        [RmName( "scope" )]
        public int Scope { get; set; } = 0;

        [RmName( "occasion" )]
        public int Occasion { get; set; } = 0;

        [RmName( "animation1_id" )]
        public int Animation1ID { get; set; } = 0;

        [RmName( "animation2_id" )]
        public int Animation2ID { get; set; } = 0;

        [RmName( "menu_se" )]
        public AudioFile MenuSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "common_event_id" )]
        public int CommonEventID { get; set; } = 0;

        [RmName( "price" )]
        public int Price { get; set; } = 0;

        [RmName( "consumable" )]
        public bool Consumable { get; set; } = true;

        [RmName( "parameter_type" )]
        public int ParameterType { get; set; } = 0;

        [RmName( "parameter_points" )]
        public int ParameterPoints { get; set; } = 0;

        [RmName( "recover_hp_rate" )]
        public int RecoverHPRate { get; set; } = 0;

        [RmName( "recover_hp" )]
        public int RecoverHP { get; set; } = 0;

        [RmName( "recover_sp_rate" )]
        public int RecoverSPRate { get; set; } = 0;

        [RmName( "recover_sp" )]
        public int RecoverSP { get; set; } = 0;

        [RmName( "hit" )]
        public int Hit { get; set; } = 100;

        [RmName( "pdef_f" )]
        public int PDefF { get; set; } = 0;

        [RmName( "mdef_f" )]
        public int MDefF { get; set; } = 0;

        [RmName( "variance" )]
        public int Variance { get; set; } = 0;

        [RmName( "element_set" )]
        public List<int> ElementSet { get; set; } = new List<int>( );

        [RmName( "plus_state_set" )]
        public List<int> PlusStateSet { get; set; } = new List<int>( );

        [RmName( "minus_state_set" )]
        public List<int> MinusStateSet { get; set; } = new List<int>( );
    }
}