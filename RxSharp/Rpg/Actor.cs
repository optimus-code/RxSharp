using RmSharp;
using RmSharp.Attributes;
using RxSharp.Converters;
using System.Collections.Generic;

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
        [RmBuffer<TableConverter>( "Table" )]
        public List<List<short>> Parameters { get; set; }

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
            Parameters = new List<List<short>>( );

            // Loop for each parameter set (total 6)
            for ( int p = 0; p < 6; p++ )
            {
                List<short> values = new List<short>( );

                // Loop from 1 to 99 to populate each parameter set
                for ( int i = 1; i <= 99; i++ )
                {
                    short value;

                    // Determine value based on the current parameter set (p)
                    if ( p == 0 || p == 1 )
                    {
                        value = ( short ) ( 500 + i * 50 );
                    }
                    else
                    {
                        value = ( short ) ( 50 + i * 5 );
                    }

                    values.Add( value );
                }

                // Add the populated values list to the Parameters list
                Parameters.Add( values );
            }
        }
    }
}