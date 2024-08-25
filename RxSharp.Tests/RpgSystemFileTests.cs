using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class RpgSystemFileTests
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "System.rxdata" ) );
        private readonly RpgSystem _expectedInstance = new RpgSystem
        {
            Dummy = 7829367,
            MagicNumber = 46695438,
            PartyMembers = new List<int> { 1, 2, 7, 8 },
            Elements = new List<string>
    {
        "", "Fire", "Ice", "Thunder", "Water", "Earth", "Wind", "Light", "Darkness", "vs Undead", "vs Snake",
        "vs Aquatic", "vs Beast", "vs Goblin", "vs Bird", "vs Devil", "vs Angel"
    },
            Switches = new List<string> { null }.Concat( Enumerable.Repeat( string.Empty, 50 ) ).ToList( ),
            Variables = new List<string> { null }.Concat( Enumerable.Repeat( string.Empty, 50 ) ).ToList( ),
            WindowskinName = "001-Blue01",
            TitleName = "001-Title01",
            GameoverName = "001-Gameover01",
            BattleTransition = "003-Blind03",
            TitleBGM = new AudioFile
            {
                Name = "064-Slow07",
                Volume = 100,
                Pitch = 100
            },
            BattleBGM = new AudioFile
            {
                Name = "001-Battle01",
                Volume = 100,
                Pitch = 100
            },
            BattleEndME = new AudioFile
            {
                Name = "001-Victory01",
                Volume = 100,
                Pitch = 100
            },
            GameoverME = new AudioFile
            {
                Name = "005-Defeat01",
                Volume = 100,
                Pitch = 100
            },
            CursorSE = new AudioFile
            {
                Name = "001-System01",
                Volume = 80,
                Pitch = 100
            },
            DecisionSE = new AudioFile
            {
                Name = "002-System02",
                Volume = 80,
                Pitch = 100
            },
            CancelSE = new AudioFile
            {
                Name = "003-System03",
                Volume = 80,
                Pitch = 100
            },
            BuzzerSE = new AudioFile
            {
                Name = "004-System04",
                Volume = 80,
                Pitch = 100
            },
            EquipSE = new AudioFile
            {
                Name = "005-System05",
                Volume = 80,
                Pitch = 100
            },
            ShopSE = new AudioFile
            {
                Name = "006-System06",
                Volume = 80,
                Pitch = 100
            },
            SaveSE = new AudioFile
            {
                Name = "007-System07",
                Volume = 80,
                Pitch = 100
            },
            LoadSE = new AudioFile
            {
                Name = "008-System08",
                Volume = 80,
                Pitch = 100
            },
            BattleStartSE = new AudioFile
            {
                Name = "009-System09",
                Volume = 80,
                Pitch = 100
            },
            EscapeSE = new AudioFile
            {
                Name = "010-System10",
                Volume = 80,
                Pitch = 100
            },
            ActorCollapseSE = new AudioFile
            {
                Name = "011-System11",
                Volume = 80,
                Pitch = 100
            },
            EnemyCollapseSE = new AudioFile
            {
                Name = "012-System12",
                Volume = 80,
                Pitch = 100
            },
            Words = new RpgSystemWords
            {
                Gold = "G",
                HP = "HP",
                SP = "SP",
                Str = "STR",
                Dex = "DEX",
                Agi = "AGI",
                Int = "INT",
                Atk = "ATK",
                PDef = "PDEF",
                MDef = "MDEF",
                Weapon = "Weapon",
                Armor1 = "Shield",
                Armor2 = "Helmet",
                Armor3 = "Body Armor",
                Armor4 = "Accessory",
                Attack = "Attack",
                Skill = "Skill",
                Guard = "Defend",
                Item = "Item",
                Equip = "Equip"
            },
            TestBattlers = new List<RpgSystemTestBattler>
    {
        new RpgSystemTestBattler
        {
            ActorID = 1,
            Level = 1,
            WeaponID = 1,
            Armor1ID = 1,
            Armor2ID = 5,
            Armor3ID = 13,
            Armor4ID = 0
        },
        new RpgSystemTestBattler
        {
            ActorID = 2,
            Level = 1,
            WeaponID = 5,
            Armor1ID = 1,
            Armor2ID = 5,
            Armor3ID = 13,
            Armor4ID = 0
        },
        new RpgSystemTestBattler
        {
            ActorID = 7,
            Level = 1,
            WeaponID = 25,
            Armor1ID = 0,
            Armor2ID = 9,
            Armor3ID = 21,
            Armor4ID = 0
        },
        new RpgSystemTestBattler
        {
            ActorID = 8,
            Level = 1,
            WeaponID = 29,
            Armor1ID = 0,
            Armor2ID = 9,
            Armor3ID = 21,
            Armor4ID = 0
        }
    },
            TestTroopID = 1,
            StartMapID = 1,
            StartX = 9,
            StartY = 7,
            BattlebackName = "003-Forest01",
            BattlerName = "001-Fighter01",
            BattlerHue = 0,
            EditMapID = 1
        };


        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var result = RmSerialiser.Deserialise<RxSharp.Rpg.RpgSystem>( ms );

                //var json = Newtonsoft.Json.JsonConvert.SerializeObject( result );

                Assert.IsNotNull( result );

                CompareObjects( _expectedInstance, result );
            }
        }

        private void CompareObjects( RpgSystem expectedValue, RpgSystem result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RpgSystem ) );

            // Compare basic properties
            Assert.AreEqual( expectedValue.Dummy, result.Dummy, $"Mismatch in {nameof( expectedValue.Dummy )}" );
            Assert.AreEqual( expectedValue.MagicNumber, result.MagicNumber, $"Mismatch in {nameof( expectedValue.MagicNumber )}" );
            Assert.AreEqual( expectedValue.WindowskinName, result.WindowskinName, $"Mismatch in {nameof( expectedValue.WindowskinName )}" );
            Assert.AreEqual( expectedValue.TitleName, result.TitleName, $"Mismatch in {nameof( expectedValue.TitleName )}" );
            Assert.AreEqual( expectedValue.GameoverName, result.GameoverName, $"Mismatch in {nameof( expectedValue.GameoverName )}" );
            Assert.AreEqual( expectedValue.BattleTransition, result.BattleTransition, $"Mismatch in {nameof( expectedValue.BattleTransition )}" );
            Assert.AreEqual( expectedValue.TestTroopID, result.TestTroopID, $"Mismatch in {nameof( expectedValue.TestTroopID )}" );
            Assert.AreEqual( expectedValue.StartMapID, result.StartMapID, $"Mismatch in {nameof( expectedValue.StartMapID )}" );
            Assert.AreEqual( expectedValue.StartX, result.StartX, $"Mismatch in {nameof( expectedValue.StartX )}" );
            Assert.AreEqual( expectedValue.StartY, result.StartY, $"Mismatch in {nameof( expectedValue.StartY )}" );
            Assert.AreEqual( expectedValue.BattlebackName, result.BattlebackName, $"Mismatch in {nameof( expectedValue.BattlebackName )}" );
            Assert.AreEqual( expectedValue.BattlerName, result.BattlerName, $"Mismatch in {nameof( expectedValue.BattlerName )}" );
            Assert.AreEqual( expectedValue.BattlerHue, result.BattlerHue, $"Mismatch in {nameof( expectedValue.BattlerHue )}" );
            Assert.AreEqual( expectedValue.EditMapID, result.EditMapID, $"Mismatch in {nameof( expectedValue.EditMapID )}" );

            // Compare AudioFile properties
            CompareAudioFiles( expectedValue.TitleBGM, result.TitleBGM, nameof( expectedValue.TitleBGM ) );
            CompareAudioFiles( expectedValue.BattleBGM, result.BattleBGM, nameof( expectedValue.BattleBGM ) );
            CompareAudioFiles( expectedValue.BattleEndME, result.BattleEndME, nameof( expectedValue.BattleEndME ) );
            CompareAudioFiles( expectedValue.GameoverME, result.GameoverME, nameof( expectedValue.GameoverME ) );
            CompareAudioFiles( expectedValue.CursorSE, result.CursorSE, nameof( expectedValue.CursorSE ) );
            CompareAudioFiles( expectedValue.DecisionSE, result.DecisionSE, nameof( expectedValue.DecisionSE ) );
            CompareAudioFiles( expectedValue.CancelSE, result.CancelSE, nameof( expectedValue.CancelSE ) );
            CompareAudioFiles( expectedValue.BuzzerSE, result.BuzzerSE, nameof( expectedValue.BuzzerSE ) );
            CompareAudioFiles( expectedValue.EquipSE, result.EquipSE, nameof( expectedValue.EquipSE ) );
            CompareAudioFiles( expectedValue.ShopSE, result.ShopSE, nameof( expectedValue.ShopSE ) );
            CompareAudioFiles( expectedValue.SaveSE, result.SaveSE, nameof( expectedValue.SaveSE ) );
            CompareAudioFiles( expectedValue.LoadSE, result.LoadSE, nameof( expectedValue.LoadSE ) );
            CompareAudioFiles( expectedValue.BattleStartSE, result.BattleStartSE, nameof( expectedValue.BattleStartSE ) );
            CompareAudioFiles( expectedValue.EscapeSE, result.EscapeSE, nameof( expectedValue.EscapeSE ) );
            CompareAudioFiles( expectedValue.ActorCollapseSE, result.ActorCollapseSE, nameof( expectedValue.ActorCollapseSE ) );
            CompareAudioFiles( expectedValue.EnemyCollapseSE, result.EnemyCollapseSE, nameof( expectedValue.EnemyCollapseSE ) );

            // Compare lists
            CollectionAssert.AreEqual( expectedValue.PartyMembers, result.PartyMembers, $"Mismatch in {nameof( expectedValue.PartyMembers )}" );
            CollectionAssert.AreEqual( expectedValue.Elements, result.Elements, $"Mismatch in {nameof( expectedValue.Elements )}" );
            CollectionAssert.AreEqual( expectedValue.Switches, result.Switches, $"Mismatch in {nameof( expectedValue.Switches )}" );
            CollectionAssert.AreEqual( expectedValue.Variables, result.Variables, $"Mismatch in {nameof( expectedValue.Variables )}" );

            // Compare words
            CompareWords( expectedValue.Words, result.Words );

            // Compare test battlers
            for ( int i = 0; i < expectedValue.TestBattlers.Count; i++ )
            {
                CompareTestBattlers( expectedValue.TestBattlers[i], result.TestBattlers[i] );
            }
        }

        private void CompareAudioFiles( AudioFile expected, AudioFile result, string propertyName )
        {
            if ( expected == null && result == null )
                return;

            Assert.IsNotNull( result, $"Expected {propertyName} to be not null" );
            Assert.AreEqual( expected.Name, result.Name, $"Mismatch in {propertyName}.Name" );
            Assert.AreEqual( expected.Volume, result.Volume, $"Mismatch in {propertyName}.Volume" );
            Assert.AreEqual( expected.Pitch, result.Pitch, $"Mismatch in {propertyName}.Pitch" );
        }

        private void CompareWords( RpgSystemWords expected, RpgSystemWords result )
        {
            if ( expected == null && result == null )
                return;

            Assert.IsNotNull( result );

            Assert.AreEqual( expected.Gold, result.Gold, $"Mismatch in {nameof( expected.Gold )}" );
            Assert.AreEqual( expected.HP, result.HP, $"Mismatch in {nameof( expected.HP )}" );
            Assert.AreEqual( expected.SP, result.SP, $"Mismatch in {nameof( expected.SP )}" );
            Assert.AreEqual( expected.Str, result.Str, $"Mismatch in {nameof( expected.Str )}" );
            Assert.AreEqual( expected.Dex, result.Dex, $"Mismatch in {nameof( expected.Dex )}" );
            Assert.AreEqual( expected.Agi, result.Agi, $"Mismatch in {nameof( expected.Agi )}" );
            Assert.AreEqual( expected.Int, result.Int, $"Mismatch in {nameof( expected.Int )}" );
            Assert.AreEqual( expected.Atk, result.Atk, $"Mismatch in {nameof( expected.Atk )}" );
            Assert.AreEqual( expected.PDef, result.PDef, $"Mismatch in {nameof( expected.PDef )}" );
            Assert.AreEqual( expected.MDef, result.MDef, $"Mismatch in {nameof( expected.MDef )}" );
            Assert.AreEqual( expected.Weapon, result.Weapon, $"Mismatch in {nameof( expected.Weapon )}" );
            Assert.AreEqual( expected.Armor1, result.Armor1, $"Mismatch in {nameof( expected.Armor1 )}" );
            Assert.AreEqual( expected.Armor2, result.Armor2, $"Mismatch in {nameof( expected.Armor2 )}" );
            Assert.AreEqual( expected.Armor3, result.Armor3, $"Mismatch in {nameof( expected.Armor3 )}" );
            Assert.AreEqual( expected.Armor4, result.Armor4, $"Mismatch in {nameof( expected.Armor4 )}" );
            Assert.AreEqual( expected.Attack, result.Attack, $"Mismatch in {nameof( expected.Attack )}" );
            Assert.AreEqual( expected.Skill, result.Skill, $"Mismatch in {nameof( expected.Skill )}" );
            Assert.AreEqual( expected.Guard, result.Guard, $"Mismatch in {nameof( expected.Guard )}" );
            Assert.AreEqual( expected.Item, result.Item, $"Mismatch in {nameof( expected.Item )}" );
            Assert.AreEqual( expected.Equip, result.Equip, $"Mismatch in {nameof( expected.Equip )}" );
        }

        private void CompareTestBattlers( RpgSystemTestBattler expected, RpgSystemTestBattler result )
        {
            if ( expected == null && result == null )
                return;

            Assert.IsNotNull( result );

            Assert.AreEqual( expected.ActorID, result.ActorID, $"Mismatch in {nameof( expected.ActorID )}" );
            Assert.AreEqual( expected.Level, result.Level, $"Mismatch in {nameof( expected.Level )}" );
            Assert.AreEqual( expected.WeaponID, result.WeaponID, $"Mismatch in {nameof( expected.WeaponID )}" );
            Assert.AreEqual( expected.Armor1ID, result.Armor1ID, $"Mismatch in {nameof( expected.Armor1ID )}" );
            Assert.AreEqual( expected.Armor2ID, result.Armor2ID, $"Mismatch in {nameof( expected.Armor2ID )}" );
            Assert.AreEqual( expected.Armor3ID, result.Armor3ID, $"Mismatch in {nameof( expected.Armor3ID )}" );
            Assert.AreEqual( expected.Armor4ID, result.Armor4ID, $"Mismatch in {nameof( expected.Armor4ID )}" );
        }

        [TestMethod]
        public void Write( )
        {
            byte[] writtenData;

            using ( var memoryStream = new MemoryStream( ) )
            {
                RmSerialiser.Serialise( memoryStream, _expectedInstance );

                writtenData = memoryStream.ToArray( );

                Assert.AreEqual( _rubyMarshalData.Length, writtenData.Length );
            }

            using ( var memoryStream2 = new MemoryStream( writtenData ) )
            {
                var result = RmSerialiser.Deserialise<RxSharp.Rpg.RpgSystem>( memoryStream2 );

                Assert.IsNotNull( result );

                CompareObjects( _expectedInstance, result );
            }

            var writePath = Path.Combine( "Output", "System.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
