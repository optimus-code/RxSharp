using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Event::Page::Condition" )]
    public class EventPageCondition
    {
        [RmName( "switch1_valid" )]
        public bool Switch1Valid { get; set; } = false;

        [RmName( "switch2_valid" )]
        public bool Switch2Valid { get; set; } = false;

        [RmName( "variable_valid" )]
        public bool VariableValid { get; set; } = false;

        [RmName( "self_switch_valid" )]
        public bool SelfSwitchValid { get; set; } = false;

        [RmName( "switch1_id" )]
        public int Switch1ID { get; set; } = 1;

        [RmName( "switch2_id" )]
        public int Switch2ID { get; set; } = 1;

        [RmName( "variable_id" )]
        public int VariableID { get; set; } = 1;

        [RmName( "variable_value" )]
        public int VariableValue { get; set; } = 0;

        [RmName( "self_switch_ch" )]
        public string SelfSwitchCh { get; set; } = "A";
    }
}