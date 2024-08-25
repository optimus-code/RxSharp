using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class CommonEventsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "CommonEvents.rxdata" ) );

        private readonly List<RxSharp.Rpg.CommonEvent> _expectedInstance;

        public CommonEventsFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<CommonEvent>>( "[null,{\"ID\":1,\"Name\":\"\",\"Trigger\":0,\"SwitchID\":1,\"List\":[{\"Code\":0,\"Indent\":0,\"Parameters\":[]}]}]" );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.CommonEvent>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.CommonEvent expectedValue, RxSharp.Rpg.CommonEvent result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.CommonEvent ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.Trigger, result.Trigger, $"Mismatch in {nameof( expectedValue.Trigger )}" );
            Assert.AreEqual( expectedValue.SwitchID, result.SwitchID, $"Mismatch in {nameof( expectedValue.SwitchID )}" );

            // Compare List of EventCommand objects
            if ( expectedValue.List == null && result.List == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.List );
                Assert.AreEqual( expectedValue.List.Count, result.List.Count, $"Mismatch in {nameof( expectedValue.List )} count" );

                for ( int i = 0; i < expectedValue.List.Count; i++ )
                {
                    var expectedCommand = expectedValue.List[i];
                    var resultCommand = result.List[i];

                    Assert.AreEqual( expectedCommand.Code, resultCommand.Code, $"Mismatch in {nameof( expectedCommand.Code )} at index {i}" );
                    Assert.AreEqual( expectedCommand.Indent, resultCommand.Indent, $"Mismatch in {nameof( expectedCommand.Indent )} at index {i}" );

                    // Compare Parameters list
                    if ( expectedCommand.Parameters == null && resultCommand.Parameters == null )
                    {
                        // Both are null, no further check needed
                    }
                    else
                    {
                        Assert.IsNotNull( resultCommand.Parameters );
                        Assert.AreEqual( expectedCommand.Parameters.Count, resultCommand.Parameters.Count, $"Mismatch in {nameof( expectedCommand.Parameters )} count at index {i}" );
                        for ( int j = 0; j < expectedCommand.Parameters.Count; j++ )
                        {
                            Assert.AreEqual( expectedCommand.Parameters[j], resultCommand.Parameters[j], $"Mismatch in {nameof( expectedCommand.Parameters )}[{j}] at index {i}" );
                        }
                    }
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.CommonEvent>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "CommonEvents.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}
