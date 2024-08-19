using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Troop::Page::Condition" )]
    public class TroopPageCondition
    {
        [RmName( "turn_valid" )]
        public bool TurnValid { get; set; } = false;

        [RmName( "enemy_valid" )]
        public bool EnemyValid { get; set; } = false;

        [RmName( "actor_valid" )]
        public bool ActorValid { get; set; } = false;

        [RmName( "switch_valid" )]
        public bool SwitchValid { get; set; } = false;

        [RmName( "turn_a" )]
        public int TurnA { get; set; } = 0;

        [RmName( "turn_b" )]
        public int TurnB { get; set; } = 0;

        [RmName( "enemy_index" )]
        public int EnemyIndex { get; set; } = 0;

        [RmName( "enemy_hp" )]
        public int EnemyHP { get; set; } = 50;

        [RmName( "actor_id" )]
        public int ActorID { get; set; } = 1;

        [RmName( "actor_hp" )]
        public int ActorHD { get; set; } = 50;

        [RmName( "switch_id" )]
        public int SwitchID { get; set; } = 1;
    }
}