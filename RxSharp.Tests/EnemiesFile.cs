using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class EnemiesFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Enemies.rxdata" ) );

        private readonly List<RxSharp.Rpg.Enemy> _expectedInstance;

        public EnemiesFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Enemy>>( File.ReadAllText( Path.Combine( "Data", "Enemies.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Enemy>>( ms );

                var json = Newtonsoft.Json.JsonConvert.SerializeObject( results );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }
        }

        private void CompareObjects( RxSharp.Rpg.Enemy expectedValue, RxSharp.Rpg.Enemy result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Enemy ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.BattlerName, result.BattlerName, $"Mismatch in {nameof( expectedValue.BattlerName )}" );
            Assert.AreEqual( expectedValue.BattlerHue, result.BattlerHue, $"Mismatch in {nameof( expectedValue.BattlerHue )}" );
            Assert.AreEqual( expectedValue.MaxHP, result.MaxHP, $"Mismatch in {nameof( expectedValue.MaxHP )}" );
            Assert.AreEqual( expectedValue.MaxSP, result.MaxSP, $"Mismatch in {nameof( expectedValue.MaxSP )}" );
            Assert.AreEqual( expectedValue.Str, result.Str, $"Mismatch in {nameof( expectedValue.Str )}" );
            Assert.AreEqual( expectedValue.Dex, result.Dex, $"Mismatch in {nameof( expectedValue.Dex )}" );
            Assert.AreEqual( expectedValue.Agi, result.Agi, $"Mismatch in {nameof( expectedValue.Agi )}" );
            Assert.AreEqual( expectedValue.Int, result.Int, $"Mismatch in {nameof( expectedValue.Int )}" );
            Assert.AreEqual( expectedValue.Atk, result.Atk, $"Mismatch in {nameof( expectedValue.Atk )}" );
            Assert.AreEqual( expectedValue.PDef, result.PDef, $"Mismatch in {nameof( expectedValue.PDef )}" );
            Assert.AreEqual( expectedValue.MDef, result.MDef, $"Mismatch in {nameof( expectedValue.MDef )}" );
            Assert.AreEqual( expectedValue.Eva, result.Eva, $"Mismatch in {nameof( expectedValue.Eva )}" );
            Assert.AreEqual( expectedValue.Animation1ID, result.Animation1ID, $"Mismatch in {nameof( expectedValue.Animation1ID )}" );
            Assert.AreEqual( expectedValue.Animation2ID, result.Animation2ID, $"Mismatch in {nameof( expectedValue.Animation2ID )}" );

            // Compare ElementRanks list
            if ( expectedValue.ElementRanks == null && result.ElementRanks == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.ElementRanks );
                CollectionAssert.AreEqual( expectedValue.ElementRanks, result.ElementRanks, $"Mismatch in {nameof( expectedValue.ElementRanks )}" );
            }

            // Compare StateRanks list
            if ( expectedValue.StateRanks == null && result.StateRanks == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.StateRanks );
                CollectionAssert.AreEqual( expectedValue.StateRanks, result.StateRanks, $"Mismatch in {nameof( expectedValue.StateRanks )}" );
            }

            // Compare Actions list
            if ( expectedValue.Actions == null && result.Actions == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Actions );
                Assert.AreEqual( expectedValue.Actions.Count, result.Actions.Count, $"Mismatch in {nameof( expectedValue.Actions )} count" );
                for ( int i = 0; i < expectedValue.Actions.Count; i++ )
                {
                    var expectedAction = expectedValue.Actions[i];
                    var resultAction = result.Actions[i];
                    Assert.AreEqual( expectedAction.Kind, resultAction.Kind, $"Mismatch in {nameof( expectedAction.Kind )} at index {i}" );
                    Assert.AreEqual( expectedAction.Basic, resultAction.Basic, $"Mismatch in {nameof( expectedAction.Basic )} at index {i}" );
                    Assert.AreEqual( expectedAction.SkillID, resultAction.SkillID, $"Mismatch in {nameof( expectedAction.SkillID )} at index {i}" );
                    Assert.AreEqual( expectedAction.ConditionTurnA, resultAction.ConditionTurnA, $"Mismatch in {nameof( expectedAction.ConditionTurnA )} at index {i}" );
                    Assert.AreEqual( expectedAction.ConditionTurnB, resultAction.ConditionTurnB, $"Mismatch in {nameof( expectedAction.ConditionTurnB )} at index {i}" );
                    Assert.AreEqual( expectedAction.ConditionHP, resultAction.ConditionHP, $"Mismatch in {nameof( expectedAction.ConditionHP )} at index {i}" );
                    Assert.AreEqual( expectedAction.ConditionLevel, resultAction.ConditionLevel, $"Mismatch in {nameof( expectedAction.ConditionLevel )} at index {i}" );
                    Assert.AreEqual( expectedAction.ConditionSwitchID, resultAction.ConditionSwitchID, $"Mismatch in {nameof( expectedAction.ConditionSwitchID )} at index {i}" );
                    Assert.AreEqual( expectedAction.Rating, resultAction.Rating, $"Mismatch in {nameof( expectedAction.Rating )} at index {i}" );
                }
            }

            Assert.AreEqual( expectedValue.Exp, result.Exp, $"Mismatch in {nameof( expectedValue.Exp )}" );
            Assert.AreEqual( expectedValue.Gold, result.Gold, $"Mismatch in {nameof( expectedValue.Gold )}" );
            Assert.AreEqual( expectedValue.ItemID, result.ItemID, $"Mismatch in {nameof( expectedValue.ItemID )}" );
            Assert.AreEqual( expectedValue.WeaponID, result.WeaponID, $"Mismatch in {nameof( expectedValue.WeaponID )}" );
            Assert.AreEqual( expectedValue.ArmorID, result.ArmorID, $"Mismatch in {nameof( expectedValue.ArmorID )}" );
            Assert.AreEqual( expectedValue.TreasureProb, result.TreasureProb, $"Mismatch in {nameof( expectedValue.TreasureProb )}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Enemy>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Enemies.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
