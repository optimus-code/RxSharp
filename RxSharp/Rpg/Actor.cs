using RmSharp;
using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Actor" )]
    public class Actor : IListFile
    {
        [RmName( "id" )]
        public int ID { get; set; } = 0;

        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "class_id" )]
        public int ClassId { get; set; } = 1;

        [RmName( "initial_level" )]
        public int InitialLevel { get; set; } = 1;

        [RmName( "final_level" )]
        public int FinalLevel { get; set; } = 99;

        [RmName( "exp_basis" )]
        public int ExpBasis { get; set; } = 30;

        [RmName( "exp_inflation" )]
        public int ExpInflation { get; set; } = 30;

        [RmName( "character_name" )]
        public string CharacterName { get; set; } = "";

        [RmName( "character_hue" )]
        public int CharacterHue { get; set; } = 0;

        [RmName( "battler_name" )]
        public string BattlerName { get; set; } = "";

        [RmName( "battler_hue" )]
        public int BattlerHue { get; set; } = 0;

        [RmName( "parameters" )]
        public int[,] Parameters { get; set; } = new int[6, 100];

        [RmName( "weapon_id" )]
        public int WeaponID { get; set; } = 0;

        [RmName( "armor1_id" )]
        public int Armor1ID { get; set; } = 0;

        [RmName( "armor2_id" )]
        public int Armor2ID { get; set; } = 0;

        [RmName( "armor3_id" )]
        public int Armor3ID { get; set; } = 0;

        [RmName( "armor4_id" )]
        public int Armor4ID { get; set; } = 0;

        [RmName( "weapon_fix" )]
        public bool WeaponFix { get; set; } = false;

        [RmName( "armor1_fix" )]
        public bool Armor1Fix { get; set; } = false;

        [RmName( "armor2_fix" )]
        public bool Armor2Fix { get; set; } = false;

        [RmName( "armor3_fix" )]
        public bool Armor3Fix { get; set; } = false;

        [RmName( "armor4_fix" )]
        public bool Armor4Fix { get; set; } = false;

        public Actor( )
        {
            // Initialize Parameters based on the given formula in Ruby code
            for ( int i = 1; i <= 99; i++ )
            {
                Parameters[0, i] = 500 + i * 50;
                Parameters[1, i] = 500 + i * 50;
                Parameters[2, i] = 50 + i * 5;
                Parameters[3, i] = 50 + i * 5;
                Parameters[4, i] = 50 + i * 5;
                Parameters[5, i] = 50 + i * 5;
            }
        }
    }
}