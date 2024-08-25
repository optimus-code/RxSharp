using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class ArmorsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Armors.rxdata" ) );

        private readonly List<RxSharp.Rpg.Armor> _expectedInstance;

        public ArmorsFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Armor>>( File.ReadAllBytes( Path.Combine( "Data", "Armors.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Armor>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Armor expectedValue, RxSharp.Rpg.Armor result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Armor ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.IconName, result.IconName, $"Mismatch in {nameof( expectedValue.IconName )}" );
            Assert.AreEqual( expectedValue.Description, result.Description, $"Mismatch in {nameof( expectedValue.Description )}" );
            Assert.AreEqual( expectedValue.Kind, result.Kind, $"Mismatch in {nameof( expectedValue.Kind )}" );
            Assert.AreEqual( expectedValue.AutoStateID, result.AutoStateID, $"Mismatch in {nameof( expectedValue.AutoStateID )}" );
            Assert.AreEqual( expectedValue.Price, result.Price, $"Mismatch in {nameof( expectedValue.Price )}" );
            Assert.AreEqual( expectedValue.PDef, result.PDef, $"Mismatch in {nameof( expectedValue.PDef )}" );
            Assert.AreEqual( expectedValue.MDef, result.MDef, $"Mismatch in {nameof( expectedValue.MDef )}" );
            Assert.AreEqual( expectedValue.Eva, result.Eva, $"Mismatch in {nameof( expectedValue.Eva )}" );
            Assert.AreEqual( expectedValue.StrPlus, result.StrPlus, $"Mismatch in {nameof( expectedValue.StrPlus )}" );
            Assert.AreEqual( expectedValue.DexPlus, result.DexPlus, $"Mismatch in {nameof( expectedValue.DexPlus )}" );
            Assert.AreEqual( expectedValue.AgiPlus, result.AgiPlus, $"Mismatch in {nameof( expectedValue.AgiPlus )}" );
            Assert.AreEqual( expectedValue.IntPlus, result.IntPlus, $"Mismatch in {nameof( expectedValue.IntPlus )}" );

            // Compare GuardElementSet list
            if ( expectedValue.GuardElementSet == null && result.GuardElementSet == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.GuardElementSet );
                CollectionAssert.AreEqual( expectedValue.GuardElementSet, result.GuardElementSet, $"Mismatch in {nameof( expectedValue.GuardElementSet )}" );
            }

            // Compare GuardStateSet list
            if ( expectedValue.GuardStateSet == null && result.GuardStateSet == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.GuardStateSet );
                CollectionAssert.AreEqual( expectedValue.GuardStateSet, result.GuardStateSet, $"Mismatch in {nameof( expectedValue.GuardStateSet )}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Armor>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Armors.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
