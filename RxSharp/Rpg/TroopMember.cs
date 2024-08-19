using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Troop::Member" )]
    public class TroopMember
    {
        [RmName( "enemy_id" )]
        public int EnemyID { get; set; } = 1;

        [RmName( "x" )]
        public int X { get; set; } = 0;

        [RmName( "y" )]
        public int Y { get; set; } = 0;

        [RmName( "hidden" )]
        public bool Hidden { get; set; } = false;

        [RmName( "immortal" )]
        public bool Immortal { get; set; } = false;
    }
}