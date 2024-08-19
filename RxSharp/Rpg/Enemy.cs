using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Enemy" )]
    public class Enemy : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "battler_name" )]
        public string BattlerName { get; set; } = "";

        [RmName( "battler_hue" )]
        public int BattlerHue { get; set; } = 0;

        [RmName( "maxhp" )]
        public int MaxHP { get; set; } = 500;

        [RmName( "maxsp" )]
        public int MaxSP { get; set; } = 500;

        [RmName( "str" )]
        public int Str { get; set; } = 50;

        [RmName( "dex" )]
        public int Dex { get; set; } = 50;

        [RmName( "agi" )]
        public int Agi { get; set; } = 50;

        [RmName( "int" )]
        public int Int { get; set; } = 50;

        [RmName( "atk" )]
        public int Atk { get; set; } = 100;

        [RmName( "pdef" )]
        public int PDef { get; set; } = 100;

        [RmName( "mdef" )]
        public int MDef { get; set; } = 100;

        [RmName( "eva" )]
        public int Eva { get; set; } = 0;

        [RmName( "animation1_id" )]
        public int Animation1ID { get; set; } = 0;

        [RmName( "animation2_id" )]
        public int Animation2ID { get; set; } = 0;

        [RmName( "element_ranks" )]
        public int[] ElementRanks { get; set; } = new int[1];

        [RmName( "state_ranks" )]
        public int[] StateRanks { get; set; } = new int[1];

        [RmName( "actions" )]
        public List<EnemyAction> Actions { get; set; } = new List<EnemyAction> { new EnemyAction( ) };

        [RmName( "exp" )]
        public int Exp { get; set; } = 0;

        [RmName( "gold" )]
        public int Gold { get; set; } = 0;

        [RmName( "item_id" )]
        public int ItemID { get; set; } = 0;

        [RmName( "weapon_id" )]
        public int WeaponID { get; set; } = 0;

        [RmName( "armor_id" )]
        public int ArmorID { get; set; } = 0;

        [RmName( "treasure_prob" )]
        public int TreasureProb { get; set; } = 100;
    }
}