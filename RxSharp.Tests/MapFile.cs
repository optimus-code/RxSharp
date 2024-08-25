using RmSharp;
using RxSharp.Rpg;

namespace RxSharp.Tests
{
    [TestClass]
    public class MapFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Map002.rxdata" ) );

        private readonly RxSharp.Rpg.Map _expectedInstance = new RxSharp.Rpg.Map
        {
            TilesetID = 1,
            Width = 20,
            Height = 15,
            AutoplayBgm = false,
            Bgm = new RxSharp.Rpg.AudioFile
            {
                Name = "",
                Volume = 100,
                Pitch = 100
            },
            AutoplayBgs = false,
            Bgs = new RxSharp.Rpg.AudioFile
            {
                Name = "",
                Volume = 80,
                Pitch = 100
            },
            EncounterList = new List<int>( ),
            EncounterStep = 30,
            Data = [[[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19],
  [20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39],
  [40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59],
  [60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79],
  [80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99],
  [100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119],
  [120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139],
  [140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159],
  [160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179],
  [180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199],
  [200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219],
  [220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239],
  [240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259],
  [260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279],
  [280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299],
  [300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319],
  [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
  [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
  [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
  [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]], [[424, 425, 426, 427, 0, 0, 0, 0, 0, 0, 304, 312, 0, 0, 0, 0, 0, 0, 0, 0], [432, 433, 434, 435, 0, 0, 0, 0, 0, 0, 304, 290, 308, 324, 424, 425, 426, 427, 0, 0], [440, 441, 442, 443, 0, 0, 0, 0, 0, 0, 328, 296, 288, 312, 432, 433, 434, 435, 0, 0], [448, 449, 450, 451, 0, 0, 0, 0, 0, 0, 0, 328, 296, 312, 440, 441, 442, 443, 0, 0], [456, 457, 458, 459, 0, 0, 0, 0, 0, 0, 0, 0, 328, 326, 448, 449, 450, 451, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 456, 457, 458, 459, 0, 0], [0, 0, 322, 308, 308, 308, 308, 308, 324, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [321, 321, 297, 288, 288, 288, 288, 292, 326, 0, 0, 0, 424, 425, 426, 427, 0, 0, 0, 0], [0, 0, 328, 316, 316, 300, 316, 326, 0, 0, 0, 0, 432, 433, 434, 435, 0, 0, 0, 0], [424, 425, 426, 427, 0, 332, 0, 0, 0, 0, 0, 0, 440, 441, 442, 443, 0, 0, 0, 0], [432, 433, 434, 435, 0, 0, 0, 0, 0, 0, 0, 0, 448, 449, 450, 451, 0, 0, 0, 0], [440, 441, 442, 443, 0, 0, 0, 0, 0, 0, 0, 0, 456, 457, 458, 459, 0, 0, 0, 0], [448, 449, 450, 451, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [456, 457, 458, 459, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]], [[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 424, 425, 426, 427], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 432, 433, 434, 435], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 440, 441, 442, 443], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 448, 449, 450, 451], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 456, 457, 458, 459], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 424, 425, 426, 427, 0, 0, 0, 0, 424, 425, 426, 427, 0, 0], [0, 0, 0, 0, 0, 0, 432, 433, 434, 435, 0, 0, 0, 0, 432, 433, 434, 435, 0, 0], [0, 0, 0, 0, 0, 0, 440, 441, 442, 443, 0, 0, 0, 0, 440, 441, 442, 443, 0, 0], [0, 0, 0, 0, 0, 0, 448, 449, 450, 451, 0, 0, 0, 0, 448, 449, 450, 451, 0, 0], [0, 0, 0, 0, 0, 0, 456, 457, 458, 459, 0, 0, 0, 0, 456, 457, 458, 459, 0, 0]]],
            Events = new Dictionary<int, RxSharp.Rpg.Event>
{
    {
        1,
        new RxSharp.Rpg.Event
        {
            ID = 1,
            Name = "EV001",
            X = 8,
            Y = 5,
            Pages = new List<RxSharp.Rpg.EventPage>
            {
                new RxSharp.Rpg.EventPage
                {
                    Condition = new RxSharp.Rpg.EventPageCondition
                    {
                        Switch1Valid = false,
                        Switch2Valid = false,
                        VariableValid = false,
                        SelfSwitchValid = false,
                        Switch1ID = 1,
                        Switch2ID = 1,
                        VariableID = 1,
                        VariableValue = 0,
                        SelfSwitchCh = "A"
                    },
                    Graphic = new RxSharp.Rpg.EventPageGraphic
                    {
                        TileID = 0,
                        CharacterName = "",
                        CharacterHue = 0,
                        Direction = 2,
                        Pattern = 0,
                        Opacity = 255,
                        BlendType = 0
                    },
                    MoveType = 0,
                    MoveSpeed = 3,
                    MoveFrequency = 3,
                    MoveRoute = new RxSharp.Rpg.MoveRoute
                    {
                        Repeat = true,
                        Skippable = false,
                        List = new List<RxSharp.Rpg.MoveCommand>
                        {
                            new RxSharp.Rpg.MoveCommand { Code = 0, Parameters = [] }
                        }
                    },
                    WalkAnime = true,
                    StepAnime = false,
                    DirectionFix = false,
                    Through = false,
                    AlwaysOnTop = false,
                    Trigger = 1,
                    List = new List<RxSharp.Rpg.EventCommand>
                    {
                        new RxSharp.Rpg.EventCommand { Code = 101, Indent = 0, Parameters =["hello"] },
                        new RxSharp.Rpg.EventCommand { Code = 0, Indent = 0, Parameters = [] }
                    }
                }
            }
        }
    }
}

        };


        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var result = RmSerialiser.Deserialise<RxSharp.Rpg.Map>( ms );

                //var json = System.Text.Json.JsonSerializer.Serialize( result );
                Assert.IsNotNull( result );

                CompareObjects( _expectedInstance, result );
            }
        }

        private void CompareObjects( RxSharp.Rpg.Map expectedValue, RxSharp.Rpg.Map result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Map ) );

            Assert.AreEqual( expectedValue.TilesetID, result.TilesetID, $"Mismatch in {nameof( expectedValue.TilesetID )}" );
            Assert.AreEqual( expectedValue.Width, result.Width, $"Mismatch in {nameof( expectedValue.Width )}" );
            Assert.AreEqual( expectedValue.Height, result.Height, $"Mismatch in {nameof( expectedValue.Height )}" );
            Assert.AreEqual( expectedValue.AutoplayBgm, result.AutoplayBgm, $"Mismatch in {nameof( expectedValue.AutoplayBgm )}" );

            Assert.AreEqual( expectedValue.Bgm.Name, result.Bgm.Name, $"Mismatch in {nameof( expectedValue.Bgm )}.{nameof( expectedValue.Bgm.Name )}" );
            Assert.AreEqual( expectedValue.Bgm.Volume, result.Bgm.Volume, $"Mismatch in {nameof( expectedValue.Bgm )}.{nameof( expectedValue.Bgm.Volume )}" );
            Assert.AreEqual( expectedValue.Bgm.Pitch, result.Bgm.Pitch, $"Mismatch in {nameof( expectedValue.Bgm )}.{nameof( expectedValue.Bgm.Pitch )}" );

            Assert.AreEqual( expectedValue.AutoplayBgs, result.AutoplayBgs, $"Mismatch in {nameof( expectedValue.AutoplayBgs )}" );

            Assert.AreEqual( expectedValue.Bgs.Name, result.Bgs.Name, $"Mismatch in {nameof( expectedValue.Bgs )}.{nameof( expectedValue.Bgs.Name )}" );
            Assert.AreEqual( expectedValue.Bgs.Volume, result.Bgs.Volume, $"Mismatch in {nameof( expectedValue.Bgs )}.{nameof( expectedValue.Bgs.Volume )}" );
            Assert.AreEqual( expectedValue.Bgs.Pitch, result.Bgs.Pitch, $"Mismatch in {nameof( expectedValue.Bgs )}.{nameof( expectedValue.Bgs.Pitch )}" );

            CollectionAssert.AreEqual( expectedValue.EncounterList, result.EncounterList, $"Mismatch in {nameof( expectedValue.EncounterList )}" );
            Assert.AreEqual( expectedValue.EncounterStep, result.EncounterStep, $"Mismatch in {nameof( expectedValue.EncounterStep )}" );

            // Compare Data (3D List)
            if ( expectedValue.Data != null && result.Data != null )
            {
                Assert.AreEqual( expectedValue.Data.Count, result.Data.Count, $"Mismatch in {nameof( expectedValue.Data )} count" );
                for ( int x = 0; x < expectedValue.Data.Count; x++ )
                {
                    Assert.AreEqual( expectedValue.Data[x].Count, result.Data[x].Count, $"Mismatch in {nameof( expectedValue.Data )}[{x}] count" );
                    for ( int y = 0; y < expectedValue.Data[x].Count; y++ )
                    {
                        CollectionAssert.AreEqual( expectedValue.Data[x][y], result.Data[x][y], $"Mismatch in {nameof( expectedValue.Data )}[{x}][{y}]" );
                    }
                }
            }
            else
            {
                Assert.AreEqual( expectedValue.Data, result.Data, $"Mismatch in {nameof( expectedValue.Data )}" );
            }

            // Compare Events dictionary
            CollectionAssert.AreEquivalent( expectedValue.Events.Keys, result.Events.Keys, $"Mismatch in {nameof( expectedValue.Events )} keys" );
            foreach ( var key in expectedValue.Events.Keys )
            {
                var expectedEvent = expectedValue.Events[key];
                var resultEvent = result.Events[key];

                Assert.IsNotNull( resultEvent, $"Missing event in result with key {key}" );

                Assert.AreEqual( expectedEvent.ID, resultEvent.ID, $"Mismatch in {nameof( resultEvent.ID )} for event {key}" );
                Assert.AreEqual( expectedEvent.Name, resultEvent.Name, $"Mismatch in {nameof( resultEvent.Name )} for event {key}" );
                Assert.AreEqual( expectedEvent.X, resultEvent.X, $"Mismatch in {nameof( resultEvent.X )} for event {key}" );
                Assert.AreEqual( expectedEvent.Y, resultEvent.Y, $"Mismatch in {nameof( resultEvent.Y )} for event {key}" );

                // Compare Event Pages
                Assert.AreEqual( expectedEvent.Pages.Count, resultEvent.Pages.Count, $"Mismatch in page count for event {key}" );

                for ( int i = 0; i < expectedEvent.Pages.Count; i++ )
                {
                    var expectedPage = expectedEvent.Pages[i];
                    var resultPage = resultEvent.Pages[i];

                    // Compare EventPage properties
                    Assert.AreEqual( expectedPage.MoveType, resultPage.MoveType, $"Mismatch in {nameof( resultPage.MoveType )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.MoveSpeed, resultPage.MoveSpeed, $"Mismatch in {nameof( resultPage.MoveSpeed )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.MoveFrequency, resultPage.MoveFrequency, $"Mismatch in {nameof( resultPage.MoveFrequency )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.WalkAnime, resultPage.WalkAnime, $"Mismatch in {nameof( resultPage.WalkAnime )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.StepAnime, resultPage.StepAnime, $"Mismatch in {nameof( resultPage.StepAnime )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.DirectionFix, resultPage.DirectionFix, $"Mismatch in {nameof( resultPage.DirectionFix )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Through, resultPage.Through, $"Mismatch in {nameof( resultPage.Through )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.AlwaysOnTop, resultPage.AlwaysOnTop, $"Mismatch in {nameof( resultPage.AlwaysOnTop )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Trigger, resultPage.Trigger, $"Mismatch in {nameof( resultPage.Trigger )} for event {key} on page {i}" );

                    // Compare EventPage Condition
                    Assert.AreEqual( expectedPage.Condition.Switch1Valid, resultPage.Condition.Switch1Valid, $"Mismatch in {nameof( resultPage.Condition.Switch1Valid )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.Switch2Valid, resultPage.Condition.Switch2Valid, $"Mismatch in {nameof( resultPage.Condition.Switch2Valid )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.VariableValid, resultPage.Condition.VariableValid, $"Mismatch in {nameof( resultPage.Condition.VariableValid )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.SelfSwitchValid, resultPage.Condition.SelfSwitchValid, $"Mismatch in {nameof( resultPage.Condition.SelfSwitchValid )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.Switch1ID, resultPage.Condition.Switch1ID, $"Mismatch in {nameof( resultPage.Condition.Switch1ID )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.Switch2ID, resultPage.Condition.Switch2ID, $"Mismatch in {nameof( resultPage.Condition.Switch2ID )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.VariableID, resultPage.Condition.VariableID, $"Mismatch in {nameof( resultPage.Condition.VariableID )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.VariableValue, resultPage.Condition.VariableValue, $"Mismatch in {nameof( resultPage.Condition.VariableValue )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Condition.SelfSwitchCh, resultPage.Condition.SelfSwitchCh, $"Mismatch in {nameof( resultPage.Condition.SelfSwitchCh )} for event {key} on page {i}" );

                    // Compare EventPage Graphic
                    Assert.AreEqual( expectedPage.Graphic.TileID, resultPage.Graphic.TileID, $"Mismatch in {nameof( resultPage.Graphic.TileID )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.CharacterName, resultPage.Graphic.CharacterName, $"Mismatch in {nameof( resultPage.Graphic.CharacterName )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.CharacterHue, resultPage.Graphic.CharacterHue, $"Mismatch in {nameof( resultPage.Graphic.CharacterHue )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.Direction, resultPage.Graphic.Direction, $"Mismatch in {nameof( resultPage.Graphic.Direction )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.Pattern, resultPage.Graphic.Pattern, $"Mismatch in {nameof( resultPage.Graphic.Pattern )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.Opacity, resultPage.Graphic.Opacity, $"Mismatch in {nameof( resultPage.Graphic.Opacity )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.Graphic.BlendType, resultPage.Graphic.BlendType, $"Mismatch in {nameof( resultPage.Graphic.BlendType )} for event {key} on page {i}" );

                    // Compare EventPage MoveRoute
                    Assert.AreEqual( expectedPage.MoveRoute.Repeat, resultPage.MoveRoute.Repeat, $"Mismatch in {nameof( resultPage.MoveRoute.Repeat )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.MoveRoute.Skippable, resultPage.MoveRoute.Skippable, $"Mismatch in {nameof( resultPage.MoveRoute.Skippable )} for event {key} on page {i}" );
                    Assert.AreEqual( expectedPage.MoveRoute.List.Count, resultPage.MoveRoute.List.Count, $"Mismatch in MoveRoute list count for event {key} on page {i}" );

                    for ( int j = 0; j < expectedPage.MoveRoute.List.Count; j++ )
                    {
                        var expectedCommand = expectedPage.MoveRoute.List[j];
                        var resultCommand = resultPage.MoveRoute.List[j];

                        Assert.AreEqual( expectedCommand.Code, resultCommand.Code, $"Mismatch in MoveRoute command code for event {key} on page {i} at index {j}" );
                        CollectionAssert.AreEqual( expectedCommand.Parameters, resultCommand.Parameters, $"Mismatch in MoveRoute command parameters for event {key} on page {i} at index {j}" );
                    }

                    // Compare EventPage Commands List
                    Assert.AreEqual( expectedPage.List.Count, resultPage.List.Count, $"Mismatch in event command list count for event {key} on page {i}" );

                    for ( int k = 0; k < expectedPage.List.Count; k++ )
                    {
                        var expectedCommand = expectedPage.List[k];
                        var resultCommand = resultPage.List[k];

                        Assert.AreEqual( expectedCommand.Code, resultCommand.Code, $"Mismatch in event command code for event {key} on page {i} at index {k}" );
                        Assert.AreEqual( expectedCommand.Indent, resultCommand.Indent, $"Mismatch in event command indent for event {key} on page {i} at index {k}" );
                        CollectionAssert.AreEqual( expectedCommand.Parameters, resultCommand.Parameters, $"Mismatch in event command parameters for event {key} on page {i} at index {k}" );
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

               // Assert.AreEqual( _rubyMarshalData.Length, writtenData.Length );
            }

            //using ( var memoryStream2 = new MemoryStream( writtenData ) )
            //{
            //    var result = RmSerialiser.Deserialise<RxSharp.Rpg.Map>( memoryStream2 );

            //    Assert.IsNotNull( result );

            //    CompareObjects( _expectedInstance, result );
            //}

            var writePath = Path.Combine( "Output", "Map001.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}