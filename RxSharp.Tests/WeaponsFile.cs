using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class WeaponsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Weapons.rxdata" ) );

        private readonly List<RxSharp.Rpg.Weapon> _expectedInstance;

        public WeaponsFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Weapon>>( File.ReadAllBytes( Path.Combine( "Data", "Weapons.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Weapon>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Weapon expectedValue, RxSharp.Rpg.Weapon result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Weapon ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.IconName, result.IconName, $"Mismatch in {nameof( expectedValue.IconName )}" );
            Assert.AreEqual( expectedValue.Description, result.Description, $"Mismatch in {nameof( expectedValue.Description )}" );
            Assert.AreEqual( expectedValue.Animation1ID, result.Animation1ID, $"Mismatch in {nameof( expectedValue.Animation1ID )}" );
            Assert.AreEqual( expectedValue.Animation2ID, result.Animation2ID, $"Mismatch in {nameof( expectedValue.Animation2ID )}" );
            Assert.AreEqual( expectedValue.Price, result.Price, $"Mismatch in {nameof( expectedValue.Price )}" );
            Assert.AreEqual( expectedValue.Atk, result.Atk, $"Mismatch in {nameof( expectedValue.Atk )}" );
            Assert.AreEqual( expectedValue.PDef, result.PDef, $"Mismatch in {nameof( expectedValue.PDef )}" );
            Assert.AreEqual( expectedValue.MDef, result.MDef, $"Mismatch in {nameof( expectedValue.MDef )}" );
            Assert.AreEqual( expectedValue.StrPlus, result.StrPlus, $"Mismatch in {nameof( expectedValue.StrPlus )}" );
            Assert.AreEqual( expectedValue.DexPlus, result.DexPlus, $"Mismatch in {nameof( expectedValue.DexPlus )}" );
            Assert.AreEqual( expectedValue.AgiPlus, result.AgiPlus, $"Mismatch in {nameof( expectedValue.AgiPlus )}" );
            Assert.AreEqual( expectedValue.IntPlus, result.IntPlus, $"Mismatch in {nameof( expectedValue.IntPlus )}" );

            // Compare ElementSet list
            if ( expectedValue.ElementSet == null && result.ElementSet == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.ElementSet );
                CollectionAssert.AreEqual( expectedValue.ElementSet, result.ElementSet, $"Mismatch in {nameof( expectedValue.ElementSet )}" );
            }

            // Compare PlusStateSet list
            if ( expectedValue.PlusStateSet == null && result.PlusStateSet == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.PlusStateSet );
                CollectionAssert.AreEqual( expectedValue.PlusStateSet, result.PlusStateSet, $"Mismatch in {nameof( expectedValue.PlusStateSet )}" );
            }

            // Compare MinusStateSet list
            if ( expectedValue.MinusStateSet == null && result.MinusStateSet == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.MinusStateSet );
                CollectionAssert.AreEqual( expectedValue.MinusStateSet, result.MinusStateSet, $"Mismatch in {nameof( expectedValue.MinusStateSet )}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Weapon>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Weapons.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
