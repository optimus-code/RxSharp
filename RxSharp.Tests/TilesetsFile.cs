using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class TilesetsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Tilesets.rxdata" ) );

        private readonly List<RxSharp.Rpg.Tileset> _expectedInstance;

        public TilesetsFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Tileset>>( File.ReadAllText( Path.Combine( "Data", "Tilesets.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Tileset>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Tileset expectedValue, RxSharp.Rpg.Tileset result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Tileset ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.TilesetName, result.TilesetName, $"Mismatch in {nameof( expectedValue.TilesetName )}" );

            // Compare AutotileNames array
            CollectionAssert.AreEqual( expectedValue.AutotileNames, result.AutotileNames, $"Mismatch in {nameof( expectedValue.AutotileNames )}" );

            Assert.AreEqual( expectedValue.PanoramaName, result.PanoramaName, $"Mismatch in {nameof( expectedValue.PanoramaName )}" );
            Assert.AreEqual( expectedValue.PanoramaHue, result.PanoramaHue, $"Mismatch in {nameof( expectedValue.PanoramaHue )}" );
            Assert.AreEqual( expectedValue.FogName, result.FogName, $"Mismatch in {nameof( expectedValue.FogName )}" );
            Assert.AreEqual( expectedValue.FogHue, result.FogHue, $"Mismatch in {nameof( expectedValue.FogHue )}" );
            Assert.AreEqual( expectedValue.FogOpacity, result.FogOpacity, $"Mismatch in {nameof( expectedValue.FogOpacity )}" );
            Assert.AreEqual( expectedValue.FogBlendType, result.FogBlendType, $"Mismatch in {nameof( expectedValue.FogBlendType )}" );
            Assert.AreEqual( expectedValue.FogZoom, result.FogZoom, $"Mismatch in {nameof( expectedValue.FogZoom )}" );
            Assert.AreEqual( expectedValue.FogSX, result.FogSX, $"Mismatch in {nameof( expectedValue.FogSX )}" );
            Assert.AreEqual( expectedValue.FogSY, result.FogSY, $"Mismatch in {nameof( expectedValue.FogSY )}" );
            Assert.AreEqual( expectedValue.BattlebackName, result.BattlebackName, $"Mismatch in {nameof( expectedValue.BattlebackName )}" );

            // Compare Passages list
            if ( expectedValue.Passages == null && result.Passages == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Passages );
                CollectionAssert.AreEqual( expectedValue.Passages, result.Passages, $"Mismatch in {nameof( expectedValue.Passages )}" );
            }

            // Compare Priorities list
            if ( expectedValue.Priorities == null && result.Priorities == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Priorities );
                CollectionAssert.AreEqual( expectedValue.Priorities, result.Priorities, $"Mismatch in {nameof( expectedValue.Priorities )}" );
            }

            // Compare TerrainTags list
            if ( expectedValue.TerrainTags == null && result.TerrainTags == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.TerrainTags );
                CollectionAssert.AreEqual( expectedValue.TerrainTags, result.TerrainTags, $"Mismatch in {nameof( expectedValue.TerrainTags )}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Tileset>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Tilesets.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
