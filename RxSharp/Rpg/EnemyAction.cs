using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Enemy::Action" )]
    public class EnemyAction
    {
        [RmName( "kind" )]
        public int Kind { get; set; } = 0;

        [RmName( "basic" )]
        public int Basic { get; set; } = 0;

        [RmName( "skill_id" )]
        public int SkillID { get; set; } = 1;

        [RmName( "condition_turn_a" )]
        public int ConditionTurnA { get; set; } = 0;

        [RmName( "condition_turn_b" )]
        public int ConditionTurnB { get; set; } = 1;

        [RmName( "condition_hp" )]
        public int ConditionHP { get; set; } = 100;

        [RmName( "condition_level" )]
        public int ConditionLevel { get; set; } = 1;

        [RmName( "condition_switch_id" )]
        public int ConditionSwitchID { get; set; } = 0;

        [RmName( "rating" )]
        public int Rating { get; set; } = 5;
    }
}