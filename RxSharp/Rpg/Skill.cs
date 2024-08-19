using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Skill" )]
    public class Skill : IListFile
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
        public int Occasion { get; set; } = 1;

        [RmName( "animation1_id" )]
        public int Animation1ID { get; set; } = 0;

        [RmName( "animation2_id" )]
        public int Animation2ID { get; set; } = 0;

        [RmName( "menu_se" )]
        public AudioFile MenuSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "common_event_id" )]
        public int CommonEventID { get; set; } = 0;

        [RmName( "sp_cost" )]
        public int SPCost { get; set; } = 0;

        [RmName( "power" )]
        public int Power { get; set; } = 0;

        [RmName( "atk_f" )]
        public int AtkF { get; set; } = 0;

        [RmName( "eva_f" )]
        public int EvaF { get; set; } = 0;

        [RmName( "str_f" )]
        public int StrF { get; set; } = 0;

        [RmName( "dex_f" )]
        public int DexF { get; set; } = 0;

        [RmName( "agi_f" )]
        public int AgiF { get; set; } = 0;

        [RmName( "int_f" )]
        public int IntF { get; set; } = 100;

        [RmName( "hit" )]
        public int Hit { get; set; } = 100;

        [RmName( "pdef_f" )]
        public int PDefF { get; set; } = 0;

        [RmName( "mdef_f" )]
        public int MDefF { get; set; } = 100;

        [RmName( "variance" )]
        public int Variance { get; set; } = 15;

        [RmName( "element_set" )]
        public List<int> ElementSet { get; set; } = new List<int>( );

        [RmName( "plus_state_set" )]
        public List<int> PlusStateSet { get; set; } = new List<int>( );

        [RmName( "minus_state_set" )]
        public List<int> MinusStateSet { get; set; } = new List<int>( );
    }
}