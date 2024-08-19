using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::System::TestBattler" )]
    public class RpgSystemTestBattler
    {
        [RmName( "actor_id" )]
        public int ActorID { get; set; } = 1;

        [RmName( "level" )]
        public int Level { get; set; } = 1;

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
    }
}
