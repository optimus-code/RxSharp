using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::State" )]
    public class State : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "animation_id" )]
        public int AnimationID { get; set; } = 0;

        [RmName( "restriction" )]
        public int Restriction { get; set; } = 0;

        [RmName( "nonresistance" )]
        public bool Nonresistance { get; set; } = false;

        [RmName( "zero_hp" )]
        public bool ZeroHP { get; set; } = false;

        [RmName( "cant_get_exp" )]
        public bool CantGetExp { get; set; } = false;

        [RmName( "cant_evade" )]
        public bool CantEvade { get; set; } = false;

        [RmName( "slip_damage" )]
        public bool SlipDamage { get; set; } = false;

        [RmName( "rating" )]
        public int Rating { get; set; } = 5;

        [RmName( "hit_rate" )]
        public int HitRate { get; set; } = 100;

        [RmName( "maxhp_rate" )]
        public int MaxHPRate { get; set; } = 100;

        [RmName( "maxsp_rate" )]
        public int MaxSPRate { get; set; } = 100;

        [RmName( "str_rate" )]
        public int StrRate { get; set; } = 100;

        [RmName( "dex_rate" )]
        public int DexRate { get; set; } = 100;

        [RmName( "agi_rate" )]
        public int AgiRate { get; set; } = 100;

        [RmName( "int_rate" )]
        public int IntRate { get; set; } = 100;

        [RmName( "atk_rate" )]
        public int AtkRate { get; set; } = 100;

        [RmName( "pdef_rate" )]
        public int PDefRate { get; set; } = 100;

        [RmName( "mdef_rate" )]
        public int MDefRate { get; set; } = 100;

        [RmName( "eva" )]
        public int Eva { get; set; } = 0;

        [RmName( "battle_only" )]
        public bool BattleOnly { get; set; } = true;

        [RmName( "hold_turn" )]
        public int HoldTurn { get; set; } = 0;

        [RmName( "auto_release_prob" )]
        public int AutoReleaseProb { get; set; } = 0;

        [RmName( "shock_release_prob" )]
        public int ShockReleaseProb { get; set; } = 0;

        [RmName( "guard_element_set" )]
        public List<int> GuardElementSet { get; set; } = new List<int>( );

        [RmName( "plus_state_set" )]
        public List<int> PlusStateSet { get; set; } = new List<int>( );

        [RmName( "minus_state_set" )]
        public List<int> MinusStateSet { get; set; } = new List<int>( );
    }
}