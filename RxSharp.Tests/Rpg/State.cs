using RmSharp.Converters;
using RmSharp.Tokens;

namespace RxSharp.Tests.Rpg
{
    [TestClass]
    public class State
    {
        private readonly byte[] _rubyMarshalData = new byte[] { ( byte ) RubyMarshalToken.Object,
            0x3A, 0x0F, 0x52, 0x50, 0x47, 0x3A, 0x3A, 0x53, 0x74, 0x61, 0x74,
            0x65, 0x21, 0x3A, 0x09, 0x40, 0x65, 0x76, 0x61, 0x69, 0x00, 0x3A, 0x0F,
            0x40, 0x68, 0x6F, 0x6C, 0x64, 0x5F, 0x74, 0x75, 0x72, 0x6E, 0x69, 0x00,
            0x3A, 0x0E, 0x40, 0x68, 0x69, 0x74, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x69,
            0x69, 0x3A, 0x15, 0x40, 0x6D, 0x69, 0x6E, 0x75, 0x73, 0x5F, 0x73, 0x74,
            0x61, 0x74, 0x65, 0x5F, 0x73, 0x65, 0x74, 0x5B, 0x14, 0x69, 0x07, 0x69,
            0x08, 0x69, 0x09, 0x69, 0x0A, 0x69, 0x0B, 0x69, 0x0C, 0x69, 0x0D, 0x69,
            0x0E, 0x69, 0x0F, 0x69, 0x10, 0x69, 0x11, 0x69, 0x12, 0x69, 0x13, 0x69,
            0x14, 0x69, 0x15, 0x3A, 0x0E, 0x40, 0x61, 0x74, 0x6B, 0x5F, 0x72, 0x61,
            0x74, 0x65, 0x69, 0x69, 0x3A, 0x0D, 0x40, 0x7A, 0x65, 0x72, 0x6F, 0x5F,
            0x68, 0x70, 0x54, 0x3A, 0x0A, 0x40, 0x6E, 0x61, 0x6D, 0x65, 0x22, 0x0D,
            0x4B, 0x6E, 0x6F, 0x63, 0x6B, 0x6F, 0x75, 0x74, 0x3A, 0x0E, 0x40, 0x73,
            0x74, 0x72, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69, 0x3A, 0x11, 0x40,
            0x73, 0x6C, 0x69, 0x70, 0x5F, 0x64, 0x61, 0x6D, 0x61, 0x67, 0x65, 0x46,
            0x3A, 0x11, 0x40, 0x62, 0x61, 0x74, 0x74, 0x6C, 0x65, 0x5F, 0x6F, 0x6E,
            0x6C, 0x79, 0x46, 0x3A, 0x14, 0x40, 0x70, 0x6C, 0x75, 0x73, 0x5F, 0x73,
            0x74, 0x61, 0x74, 0x65, 0x5F, 0x73, 0x65, 0x74, 0x5B, 0x00, 0x3A, 0x0E,
            0x40, 0x69, 0x6E, 0x74, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69, 0x3A,
            0x13, 0x40, 0x6E, 0x6F, 0x6E, 0x72, 0x65, 0x73, 0x69, 0x73, 0x74, 0x61,
            0x6E, 0x63, 0x65, 0x46, 0x3A, 0x0C, 0x40, 0x72, 0x61, 0x74, 0x69, 0x6E,
            0x67, 0x69, 0x0F, 0x3A, 0x18, 0x40, 0x73, 0x68, 0x6F, 0x63, 0x6B, 0x5F,
            0x72, 0x65, 0x6C, 0x65, 0x61, 0x73, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x62,
            0x69, 0x00, 0x3A, 0x10, 0x40, 0x6D, 0x61, 0x78, 0x73, 0x70, 0x5F, 0x72,
            0x61, 0x74, 0x65, 0x69, 0x69, 0x3A, 0x0F, 0x40, 0x6D, 0x64, 0x65, 0x66,
            0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69, 0x3A, 0x10, 0x40, 0x63, 0x61,
            0x6E, 0x74, 0x5F, 0x65, 0x76, 0x61, 0x64, 0x65, 0x46, 0x3A, 0x0E, 0x40,
            0x61, 0x67, 0x69, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69, 0x3A, 0x11,
            0x40, 0x72, 0x65, 0x73, 0x74, 0x72, 0x69, 0x63, 0x74, 0x69, 0x6F, 0x6E,
            0x69, 0x09, 0x3A, 0x17, 0x40, 0x61, 0x75, 0x74, 0x6F, 0x5F, 0x72, 0x65,
            0x6C, 0x65, 0x61, 0x73, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x62, 0x69, 0x00,
            0x3A, 0x10, 0x40, 0x6D, 0x61, 0x78, 0x68, 0x70, 0x5F, 0x72, 0x61, 0x74,
            0x65, 0x69, 0x69, 0x3A, 0x17, 0x40, 0x67, 0x75, 0x61, 0x72, 0x64, 0x5F,
            0x65, 0x6C, 0x65, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x65, 0x74, 0x5B,
            0x00, 0x3A, 0x12, 0x40, 0x63, 0x61, 0x6E, 0x74, 0x5F, 0x67, 0x65, 0x74,
            0x5F, 0x65, 0x78, 0x70, 0x54, 0x3A, 0x0F, 0x40, 0x70, 0x64, 0x65, 0x66,
            0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69, 0x3A, 0x08, 0x40, 0x69, 0x64,
            0x69, 0x06, 0x3A, 0x12, 0x40, 0x61, 0x6E, 0x69, 0x6D, 0x61, 0x74, 0x69,
            0x6F, 0x6E, 0x5F, 0x69, 0x64, 0x69, 0x00, 0x3A, 0x0E, 0x40, 0x64, 0x65,
            0x78, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x69, 0x69
        };

        private readonly RxSharp.Rpg.State _expectedValue = new RxSharp.Rpg.State
        {
            ID = 1,
            Name = "Knockout",
            AnimationID = 0,
            Restriction = 4,
            Nonresistance = false,
            ZeroHP = true,
            CantGetExp = true,
            CantEvade = false,
            SlipDamage = false,
            Rating = 10,
            HitRate = 100,
            MaxHPRate = 100,
            MaxSPRate = 100,
            StrRate = 100,
            DexRate = 100,
            AgiRate = 100,
            IntRate = 100,
            AtkRate = 100,
            PDefRate = 100,
            MDefRate = 100,
            Eva = 0,
            BattleOnly = false,
            HoldTurn = 0,
            AutoReleaseProb = 0,
            ShockReleaseProb = 0,
            GuardElementSet = [],
            PlusStateSet = [],
            MinusStateSet = [2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16]
        };

        [TestMethod]
        public void Read( )
        {
            var converter = RmConverterFactory.GetConverter( typeof( RxSharp.Rpg.State ) );
            ReadObject( converter, _rubyMarshalData );
        }

        private RxSharp.Rpg.State ReadObject( RmConverter converter, byte[] buffer )
        {
            using ( var memoryStream = new MemoryStream( buffer ) )
            using ( var reader = new BinaryReader( memoryStream ) )
            {
                var result = ( RxSharp.Rpg.State ) converter.Read( reader );

                CompareObjects( result );

                return result;
            }
        }

        private void CompareObjects( RxSharp.Rpg.State result )
        {
            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.State ) );

            Assert.AreEqual( _expectedValue.ID, result.ID, $"Mismatch in {nameof( _expectedValue.ID )}" );
            Assert.AreEqual( _expectedValue.Name, result.Name, $"Mismatch in {nameof( _expectedValue.Name )}" );
            Assert.AreEqual( _expectedValue.AnimationID, result.AnimationID, $"Mismatch in {nameof( _expectedValue.AnimationID )}" );
            Assert.AreEqual( _expectedValue.Restriction, result.Restriction, $"Mismatch in {nameof( _expectedValue.Restriction )}" );
            Assert.AreEqual( _expectedValue.Nonresistance, result.Nonresistance, $"Mismatch in {nameof( _expectedValue.Nonresistance )}" );
            Assert.AreEqual( _expectedValue.ZeroHP, result.ZeroHP, $"Mismatch in {nameof( _expectedValue.ZeroHP )}" );
            Assert.AreEqual( _expectedValue.CantGetExp, result.CantGetExp, $"Mismatch in {nameof( _expectedValue.CantGetExp )}" );
            Assert.AreEqual( _expectedValue.CantEvade, result.CantEvade, $"Mismatch in {nameof( _expectedValue.CantEvade )}" );
            Assert.AreEqual( _expectedValue.SlipDamage, result.SlipDamage, $"Mismatch in {nameof( _expectedValue.SlipDamage )}" );
            Assert.AreEqual( _expectedValue.Rating, result.Rating, $"Mismatch in {nameof( _expectedValue.Rating )}" );
            Assert.AreEqual( _expectedValue.HitRate, result.HitRate, $"Mismatch in {nameof( _expectedValue.HitRate )}" );
            Assert.AreEqual( _expectedValue.MaxHPRate, result.MaxHPRate, $"Mismatch in {nameof( _expectedValue.MaxHPRate )}" );
            Assert.AreEqual( _expectedValue.MaxSPRate, result.MaxSPRate, $"Mismatch in {nameof( _expectedValue.MaxSPRate )}" );
            Assert.AreEqual( _expectedValue.StrRate, result.StrRate, $"Mismatch in {nameof( _expectedValue.StrRate )}" );
            Assert.AreEqual( _expectedValue.DexRate, result.DexRate, $"Mismatch in {nameof( _expectedValue.DexRate )}" );
            Assert.AreEqual( _expectedValue.AgiRate, result.AgiRate, $"Mismatch in {nameof( _expectedValue.AgiRate )}" );
            Assert.AreEqual( _expectedValue.IntRate, result.IntRate, $"Mismatch in {nameof( _expectedValue.IntRate )}" );
            Assert.AreEqual( _expectedValue.AtkRate, result.AtkRate, $"Mismatch in {nameof( _expectedValue.AtkRate )}" );
            Assert.AreEqual( _expectedValue.PDefRate, result.PDefRate, $"Mismatch in {nameof( _expectedValue.PDefRate )}" );
            Assert.AreEqual( _expectedValue.MDefRate, result.MDefRate, $"Mismatch in {nameof( _expectedValue.MDefRate )}" );
            Assert.AreEqual( _expectedValue.Eva, result.Eva, $"Mismatch in {nameof( _expectedValue.Eva )}" );
            Assert.AreEqual( _expectedValue.BattleOnly, result.BattleOnly, $"Mismatch in {nameof( _expectedValue.BattleOnly )}" );
            Assert.AreEqual( _expectedValue.HoldTurn, result.HoldTurn, $"Mismatch in {nameof( _expectedValue.HoldTurn )}" );
            Assert.AreEqual( _expectedValue.AutoReleaseProb, result.AutoReleaseProb, $"Mismatch in {nameof( _expectedValue.AutoReleaseProb )}" );
            Assert.AreEqual( _expectedValue.ShockReleaseProb, result.ShockReleaseProb, $"Mismatch in {nameof( _expectedValue.ShockReleaseProb )}" );

            CollectionAssert.AreEqual( _expectedValue.GuardElementSet, result.GuardElementSet, $"Mismatch in {nameof( _expectedValue.GuardElementSet )}" );
            CollectionAssert.AreEqual( _expectedValue.PlusStateSet, result.PlusStateSet, $"Mismatch in {nameof( _expectedValue.PlusStateSet )}" );
            CollectionAssert.AreEqual( _expectedValue.MinusStateSet, result.MinusStateSet, $"Mismatch in {nameof( _expectedValue.MinusStateSet )}" );
        }

        [TestMethod]
        public void Write( )
        {
            var converter = RmConverterFactory.GetConverter( typeof( RxSharp.Rpg.State ) );
            using ( var memoryStream = new MemoryStream( ) )
            using ( var writer = new BinaryWriter( memoryStream ) )
            {
                converter.Write( writer, _expectedValue );

                byte[] writtenData = memoryStream.ToArray( );

                Assert.AreEqual( writtenData.Length, _rubyMarshalData.Length );

                var result = ReadObject( converter, writtenData );

                CompareObjects( result );
            }
        }
    }
}