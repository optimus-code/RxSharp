using RmSharp.Attributes;
using System.Collections.Generic;

namespace RxSharp.Rpg
{
    [RmName( "RPG::System" )]
    public class RpgSystem : ISingleInstanceFile
    {
        [RmName( "_" )]
        public long Dummy
        {
            get;
            set;
        } = 7829367;

        [RmName( "magic_number" )]
        public int MagicNumber { get; set; } = 0;

        [RmName( "party_members" )]
        public List<int> PartyMembers { get; set; } = new List<int> { 1 };

        [RmName( "elements" )]
        public List<string> Elements { get; set; } = new List<string> { null, "" };

        [RmName( "switches" )]
        public List<string> Switches { get; set; } = new List<string> { null, "" };

        [RmName( "variables" )]
        public List<string> Variables { get; set; } = new List<string> { null, "" };

        [RmName( "windowskin_name" )]
        public string WindowskinName { get; set; } = "";

        [RmName( "title_name" )]
        public string TitleName { get; set; } = "";

        [RmName( "gameover_name" )]
        public string GameoverName { get; set; } = "";

        [RmName( "battle_transition" )]
        public string BattleTransition { get; set; } = "";

        [RmName( "title_bgm" )]
        public AudioFile TitleBGM { get; set; } = new AudioFile( );

        [RmName( "battle_bgm" )]
        public AudioFile BattleBGM { get; set; } = new AudioFile( );

        [RmName( "battle_end_me" )]
        public AudioFile BattleEndME { get; set; } = new AudioFile( );

        [RmName( "gameover_me" )]
        public AudioFile GameoverME { get; set; } = new AudioFile( );

        [RmName( "cursor_se" )]
        public AudioFile CursorSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "decision_se" )]
        public AudioFile DecisionSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "cancel_se" )]
        public AudioFile CancelSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "buzzer_se" )]
        public AudioFile BuzzerSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "equip_se" )]
        public AudioFile EquipSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "shop_se" )]
        public AudioFile ShopSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "save_se" )]
        public AudioFile SaveSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "load_se" )]
        public AudioFile LoadSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "battle_start_se" )]
        public AudioFile BattleStartSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "escape_se" )]
        public AudioFile EscapeSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "actor_collapse_se" )]
        public AudioFile ActorCollapseSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "enemy_collapse_se" )]
        public AudioFile EnemyCollapseSE { get; set; } = new AudioFile( "", 80 );

        [RmName( "words" )]
        public RpgSystemWords Words { get; set; } = new RpgSystemWords( );

        [RmName( "test_battlers" )]
        public List<RpgSystemTestBattler> TestBattlers { get; set; } = new List<RpgSystemTestBattler>( );

        [RmName( "test_troop_id" )]
        public int TestTroopID { get; set; } = 1;

        [RmName( "start_map_id" )]
        public int StartMapID { get; set; } = 1;

        [RmName( "start_x" )]
        public int StartX { get; set; } = 0;

        [RmName( "start_y" )]
        public int StartY { get; set; } = 0;

        [RmName( "battleback_name" )]
        public string BattlebackName { get; set; } = "";

        [RmName( "battler_name" )]
        public string BattlerName { get; set; } = "";

        [RmName( "battler_hue" )]
        public int BattlerHue { get; set; } = 0;

        [RmName( "edit_map_id" )]
        public int EditMapID { get; set; } = 1;
    }
}