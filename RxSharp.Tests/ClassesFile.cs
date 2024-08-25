using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class ClassesFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Classes.rxdata" ) );

        private readonly List<RxSharp.Rpg.Class> _expectedInstance;

        public ClassesFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Class>>( File.ReadAllText( Path.Combine( "Data", "Classes.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Class>>( ms );

                //var json = Newtonsoft.Json.JsonConvert.SerializeObject( results );

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

        private void CompareObjects( RxSharp.Rpg.Class expectedValue, RxSharp.Rpg.Class result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Class ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.Position, result.Position, $"Mismatch in {nameof( expectedValue.Position )}" );

            // Compare WeaponSet list
            CollectionAssert.AreEqual( expectedValue.WeaponSet, result.WeaponSet, $"Mismatch in {nameof( expectedValue.WeaponSet )}" );

            // Compare ArmorSet list
            CollectionAssert.AreEqual( expectedValue.ArmorSet, result.ArmorSet, $"Mismatch in {nameof( expectedValue.ArmorSet )}" );

            // Compare ElementRanks list
            CollectionAssert.AreEqual( expectedValue.ElementRanks, result.ElementRanks, $"Mismatch in {nameof( expectedValue.ElementRanks )}" );

            // Compare StateRanks list
            CollectionAssert.AreEqual( expectedValue.StateRanks, result.StateRanks, $"Mismatch in {nameof( expectedValue.StateRanks )}" );

            // Compare Learnings list
            if ( expectedValue.Learnings == null && result.Learnings == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Learnings );
                Assert.AreEqual( expectedValue.Learnings.Count, result.Learnings.Count, $"Mismatch in {nameof( expectedValue.Learnings )} count" );

                for ( int i = 0; i < expectedValue.Learnings.Count; i++ )
                {
                    var expectedLearning = expectedValue.Learnings[i];
                    var resultLearning = result.Learnings[i];

                    Assert.AreEqual( expectedLearning.Level, resultLearning.Level, $"Mismatch in {nameof( expectedLearning.Level )} at index {i}" );
                    Assert.AreEqual( expectedLearning.SkillID, resultLearning.SkillID, $"Mismatch in {nameof( expectedLearning.SkillID )} at index {i}" );
                }
            }
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Class>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Classes.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
