using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::System::Words" )]
    public class RpgSystemWords
    {
        [RmName( "gold" )]
        public string Gold { get; set; } = "";

        [RmName( "hp" )]
        public string HP { get; set; } = "";

        [RmName( "sp" )]
        public string SP { get; set; } = "";

        [RmName( "str" )]
        public string Str { get; set; } = "";

        [RmName( "dex" )]
        public string Dex { get; set; } = "";

        [RmName( "agi" )]
        public string Agi { get; set; } = "";

        [RmName( "int" )]
        public string Int { get; set; } = "";

        [RmName( "atk" )]
        public string Atk { get; set; } = "";

        [RmName( "pdef" )]
        public string PDef { get; set; } = "";

        [RmName( "mdef" )]
        public string MDef { get; set; } = "";

        [RmName( "weapon" )]
        public string Weapon { get; set; } = "";

        [RmName( "armor1" )]
        public string Armor1 { get; set; } = "";

        [RmName( "armor2" )]
        public string Armor2 { get; set; } = "";

        [RmName( "armor3" )]
        public string Armor3 { get; set; } = "";

        [RmName( "armor4" )]
        public string Armor4 { get; set; } = "";

        [RmName( "attack" )]
        public string Attack { get; set; } = "";

        [RmName( "skill" )]
        public string Skill { get; set; } = "";

        [RmName( "guard" )]
        public string Guard { get; set; } = "";

        [RmName( "item" )]
        public string Item { get; set; } = "";

        [RmName( "equip" )]
        public string Equip { get; set; } = "";
    }
}