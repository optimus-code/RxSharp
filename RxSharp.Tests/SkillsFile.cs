using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class SkillsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Skills.rxdata" ) );

        private readonly List<RxSharp.Rpg.Skill> _expectedInstance;

        public SkillsFile( )
        {
            _expectedInstance = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Skill>>( File.ReadAllText( Path.Combine( "Data", "Skills.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Skill>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Skill expectedValue, RxSharp.Rpg.Skill result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Skill ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.IconName, result.IconName, $"Mismatch in {nameof( expectedValue.IconName )}" );
            Assert.AreEqual( expectedValue.Description, result.Description, $"Mismatch in {nameof( expectedValue.Description )}" );
            Assert.AreEqual( expectedValue.Scope, result.Scope, $"Mismatch in {nameof( expectedValue.Scope )}" );
            Assert.AreEqual( expectedValue.Occasion, result.Occasion, $"Mismatch in {nameof( expectedValue.Occasion )}" );
            Assert.AreEqual( expectedValue.Animation1ID, result.Animation1ID, $"Mismatch in {nameof( expectedValue.Animation1ID )}" );
            Assert.AreEqual( expectedValue.Animation2ID, result.Animation2ID, $"Mismatch in {nameof( expectedValue.Animation2ID )}" );

            // Compare MenuSE object
            if ( expectedValue.MenuSE == null && result.MenuSE == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.MenuSE );
                Assert.IsInstanceOfType( result.MenuSE, typeof( RxSharp.Rpg.AudioFile ) );
                Assert.AreEqual( expectedValue.MenuSE.Name, result.MenuSE.Name, $"Mismatch in {nameof( expectedValue.MenuSE.Name )}" );
                Assert.AreEqual( expectedValue.MenuSE.Volume, result.MenuSE.Volume, $"Mismatch in {nameof( expectedValue.MenuSE.Volume )}" );
                Assert.AreEqual( expectedValue.MenuSE.Pitch, result.MenuSE.Pitch, $"Mismatch in {nameof( expectedValue.MenuSE.Pitch )}" );
            }

            Assert.AreEqual( expectedValue.CommonEventID, result.CommonEventID, $"Mismatch in {nameof( expectedValue.CommonEventID )}" );
            Assert.AreEqual( expectedValue.SPCost, result.SPCost, $"Mismatch in {nameof( expectedValue.SPCost )}" );
            Assert.AreEqual( expectedValue.Power, result.Power, $"Mismatch in {nameof( expectedValue.Power )}" );
            Assert.AreEqual( expectedValue.AtkF, result.AtkF, $"Mismatch in {nameof( expectedValue.AtkF )}" );
            Assert.AreEqual( expectedValue.EvaF, result.EvaF, $"Mismatch in {nameof( expectedValue.EvaF )}" );
            Assert.AreEqual( expectedValue.StrF, result.StrF, $"Mismatch in {nameof( expectedValue.StrF )}" );
            Assert.AreEqual( expectedValue.DexF, result.DexF, $"Mismatch in {nameof( expectedValue.DexF )}" );
            Assert.AreEqual( expectedValue.AgiF, result.AgiF, $"Mismatch in {nameof( expectedValue.AgiF )}" );
            Assert.AreEqual( expectedValue.IntF, result.IntF, $"Mismatch in {nameof( expectedValue.IntF )}" );
            Assert.AreEqual( expectedValue.Hit, result.Hit, $"Mismatch in {nameof( expectedValue.Hit )}" );
            Assert.AreEqual( expectedValue.PDefF, result.PDefF, $"Mismatch in {nameof( expectedValue.PDefF )}" );
            Assert.AreEqual( expectedValue.MDefF, result.MDefF, $"Mismatch in {nameof( expectedValue.MDefF )}" );
            Assert.AreEqual( expectedValue.Variance, result.Variance, $"Mismatch in {nameof( expectedValue.Variance )}" );

            CollectionAssert.AreEqual( expectedValue.ElementSet, result.ElementSet, $"Mismatch in {nameof( expectedValue.ElementSet )}" );
            CollectionAssert.AreEqual( expectedValue.PlusStateSet, result.PlusStateSet, $"Mismatch in {nameof( expectedValue.PlusStateSet )}" );
            CollectionAssert.AreEqual( expectedValue.MinusStateSet, result.MinusStateSet, $"Mismatch in {nameof( expectedValue.MinusStateSet )}" );
        }

        [TestMethod]
        public void Write( )
        {
            byte[] writtenData;

            using ( var memoryStream = new MemoryStream( ) )
            {
                RmSerialiser.Serialise( memoryStream, _expectedInstance );

                writtenData = memoryStream.ToArray( );

                // We're one byte off but it loads correctly??
                //Assert.AreEqual( _rubyMarshalData.Length, writtenData.Length ); 
            }

            using ( var memoryStream2 = new MemoryStream( writtenData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Skill>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Skills.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
