using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class MapInfosFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "MapInfos.rxdata" ) );

        private readonly Dictionary<int, RxSharp.Rpg.MapInfo> _expectedInstance;

        public MapInfosFile( )
        {
            _expectedInstance = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, RxSharp.Rpg.MapInfo>>( File.ReadAllText( Path.Combine( "Data", "MapInfos.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<Dictionary<int,RxSharp.Rpg.MapInfo>>( ms );

                //var json = System.Text.Json.JsonSerializer.Serialize( results );
                //File.WriteAllText( "C:\\Users\\User\\source\\repos\\RmSharp\\RmSharp\\bin\\Debug\\net8.0\\temp.json", json );
                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                foreach ( var key in _expectedInstance.Keys )
                {
                    var expected = _expectedInstance[key];
                    var result = results[key];
                    CompareObjects( expected, result );
                }
            }
        }

        private void CompareObjects( RxSharp.Rpg.MapInfo expectedValue, RxSharp.Rpg.MapInfo result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.MapInfo ) );

            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.ParentID, result.ParentID, $"Mismatch in {nameof( expectedValue.ParentID )}" );
            Assert.AreEqual( expectedValue.Order, result.Order, $"Mismatch in {nameof( expectedValue.Order )}" );
            Assert.AreEqual( expectedValue.Expanded, result.Expanded, $"Mismatch in {nameof( expectedValue.Expanded )}" );
            Assert.AreEqual( expectedValue.ScrollX, result.ScrollX, $"Mismatch in {nameof( expectedValue.ScrollX )}" );
            Assert.AreEqual( expectedValue.ScrollY, result.ScrollY, $"Mismatch in {nameof( expectedValue.ScrollY )}" );
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
                var results = RmSerialiser.Deserialise<Dictionary<int, RxSharp.Rpg.MapInfo>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                foreach ( var key in _expectedInstance.Keys )
                {
                    var expected = _expectedInstance[key];
                    var result = results[key];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "MapInfos.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
