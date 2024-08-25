using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class AnimationsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Animations.rxdata" ) );

        private readonly List<RxSharp.Rpg.Animation> _expectedInstance;

        public AnimationsFile( )
        {
            _expectedInstance = System.Text.Json.JsonSerializer.Deserialize<List<Animation>>( File.ReadAllBytes( Path.Combine( "Data", "Animations.json" ) ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Animation>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Animation expectedValue, RxSharp.Rpg.Animation result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Animation ) );

            Assert.AreEqual( expectedValue.ID, result.ID, $"Mismatch in {nameof( expectedValue.ID )}" );
            Assert.AreEqual( expectedValue.Name, result.Name, $"Mismatch in {nameof( expectedValue.Name )}" );
            Assert.AreEqual( expectedValue.AnimationName, result.AnimationName, $"Mismatch in {nameof( expectedValue.AnimationName )}" );
            Assert.AreEqual( expectedValue.AnimationHue, result.AnimationHue, $"Mismatch in {nameof( expectedValue.AnimationHue )}" );
            Assert.AreEqual( expectedValue.Position, result.Position, $"Mismatch in {nameof( expectedValue.Position )}" );
            Assert.AreEqual( expectedValue.FrameMax, result.FrameMax, $"Mismatch in {nameof( expectedValue.FrameMax )}" );

            // Compare Frames List
            if ( expectedValue.Frames == null && result.Frames == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Frames );
                Assert.AreEqual( expectedValue.Frames.Count, result.Frames.Count, $"Mismatch in {nameof( expectedValue.Frames )} count" );

                for ( int i = 0; i < expectedValue.Frames.Count; i++ )
                {
                    var expectedFrame = expectedValue.Frames[i];
                    var resultFrame = result.Frames[i];

                    Assert.AreEqual( expectedFrame.CellMax, resultFrame.CellMax, $"Mismatch in {nameof( expectedFrame.CellMax )} at index {i}" );

                    // Compare CellData
                    if ( expectedFrame.CellData == null && resultFrame.CellData == null )
                    {
                        // Both are null, no further check needed
                    }
                    else
                    {
                        Assert.IsNotNull( resultFrame.CellData );
                        Assert.AreEqual( expectedFrame.CellData.Count, resultFrame.CellData.Count, $"Mismatch in {nameof( expectedFrame.CellData )} count at index {i}" );

                        for ( int j = 0; j < expectedFrame.CellData.Count; j++ )
                        {
                            CollectionAssert.AreEqual( expectedFrame.CellData[j], resultFrame.CellData[j], $"Mismatch in {nameof( expectedFrame.CellData )}[{j}] at frame index {i}" );
                        }
                    }
                }
            }

            // Compare Timings List
            if ( expectedValue.Timings == null && result.Timings == null )
            {
                // Both are null, no further check needed
            }
            else
            {
                Assert.IsNotNull( result.Timings );
                Assert.AreEqual( expectedValue.Timings.Count, result.Timings.Count, $"Mismatch in {nameof( expectedValue.Timings )} count" );

                for ( int i = 0; i < expectedValue.Timings.Count; i++ )
                {
                    var expectedTiming = expectedValue.Timings[i];
                    var resultTiming = result.Timings[i];

                    Assert.AreEqual( expectedTiming.Frame, resultTiming.Frame, $"Mismatch in {nameof( expectedTiming.Frame )} at index {i}" );
                    Assert.AreEqual( expectedTiming.SE.Name, resultTiming.SE.Name, $"Mismatch in {nameof( expectedTiming.SE.Name )} at index {i}" );
                    Assert.AreEqual( expectedTiming.SE.Volume, resultTiming.SE.Volume, $"Mismatch in {nameof( expectedTiming.SE.Volume )} at index {i}" );
                    Assert.AreEqual( expectedTiming.SE.Pitch, resultTiming.SE.Pitch, $"Mismatch in {nameof( expectedTiming.SE.Pitch )} at index {i}" );
                    Assert.AreEqual( expectedTiming.FlashScope, resultTiming.FlashScope, $"Mismatch in {nameof( expectedTiming.FlashScope )} at index {i}" );
                    Assert.AreEqual( expectedTiming.FlashColor, resultTiming.FlashColor, $"Mismatch in {nameof( expectedTiming.FlashColor )} at index {i}" );
                    Assert.AreEqual( expectedTiming.FlashDuration, resultTiming.FlashDuration, $"Mismatch in {nameof( expectedTiming.FlashDuration )} at index {i}" );
                    Assert.AreEqual( expectedTiming.Condition, resultTiming.Condition, $"Mismatch in {nameof( expectedTiming.Condition )} at index {i}" );
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
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Animation>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Animations.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}