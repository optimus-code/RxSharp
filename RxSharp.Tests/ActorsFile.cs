using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class ActorsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Actors.rxdata" ) );

        private readonly List<RxSharp.Rpg.Actor> _expectedInstance;

        public ActorsFile() 
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Actor>>( File.ReadAllBytes( Path.Combine( "Data", "Actors.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Actor>>( ms );

                //var json = System.Text.Json.JsonSerializer.Serialize( results );

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

        private void CompareObjects( RxSharp.Rpg.Actor expectedValue, RxSharp.Rpg.Actor result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Actor ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.ClassId, result.ClassId, $"Mismatch in {nameof( expectedValue.ClassId )}" );
            Assert.AreEqual( expectedValue.InitialLevel, result.InitialLevel, $"Mismatch in {nameof( expectedValue.InitialLevel )}" );
            Assert.AreEqual( expectedValue.FinalLevel, result.FinalLevel, $"Mismatch in {nameof( expectedValue.FinalLevel )}" );
            Assert.AreEqual( expectedValue.ExpBasis, result.ExpBasis, $"Mismatch in {nameof( expectedValue.ExpBasis )}" );
            Assert.AreEqual( expectedValue.ExpInflation, result.ExpInflation, $"Mismatch in {nameof( expectedValue.ExpInflation )}" );
            Assert.AreEqual( expectedValue.CharacterName, result.CharacterName, $"Mismatch in {nameof( expectedValue.CharacterName )}" );
            Assert.AreEqual( expectedValue.CharacterHue, result.CharacterHue, $"Mismatch in {nameof( expectedValue.CharacterHue )}" );
            Assert.AreEqual( expectedValue.BattlerName, result.BattlerName, $"Mismatch in {nameof( expectedValue.BattlerName )}" );
            Assert.AreEqual( expectedValue.BattlerHue, result.BattlerHue, $"Mismatch in {nameof( expectedValue.BattlerHue )}" );

            // Compare Parameters object
            if ( expectedValue.Parameters == null && result.Parameters == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Parameters );
                Assert.IsInstanceOfType( result.Parameters, typeof( List<List<short>> ) );
                
                for ( var i = 0; i < result.Parameters.Count; i++ )
                {
                    var resultSet = result.Parameters[i];
                    var expectedSet = expectedValue.Parameters[i];

                    CollectionAssert.AreEqual( resultSet, expectedSet, $"Mismatch in {nameof( expectedValue.Parameters )}" );
                }
            }

            Assert.AreEqual( expectedValue.WeaponID, result.WeaponID, $"Mismatch in {nameof( expectedValue.WeaponID )}" );
            Assert.AreEqual( expectedValue.Armor1ID, result.Armor1ID, $"Mismatch in {nameof( expectedValue.Armor1ID )}" );
            Assert.AreEqual( expectedValue.Armor2ID, result.Armor2ID, $"Mismatch in {nameof( expectedValue.Armor2ID )}" );
            Assert.AreEqual( expectedValue.Armor3ID, result.Armor3ID, $"Mismatch in {nameof( expectedValue.Armor3ID )}" );
            Assert.AreEqual( expectedValue.Armor4ID, result.Armor4ID, $"Mismatch in {nameof( expectedValue.Armor4ID )}" );

            Assert.AreEqual( expectedValue.WeaponFix, result.WeaponFix, $"Mismatch in {nameof( expectedValue.WeaponFix )}" );
            Assert.AreEqual( expectedValue.Armor1Fix, result.Armor1Fix, $"Mismatch in {nameof( expectedValue.Armor1Fix )}" );
            Assert.AreEqual( expectedValue.Armor2Fix, result.Armor2Fix, $"Mismatch in {nameof( expectedValue.Armor2Fix )}" );
            Assert.AreEqual( expectedValue.Armor3Fix, result.Armor3Fix, $"Mismatch in {nameof( expectedValue.Armor3Fix )}" );
            Assert.AreEqual( expectedValue.Armor4Fix, result.Armor4Fix, $"Mismatch in {nameof( expectedValue.Armor4Fix )}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Actor>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Actors.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}