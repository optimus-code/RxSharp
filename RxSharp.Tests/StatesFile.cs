using RmSharp;

namespace RxSharp.Tests
{
    [TestClass]
    public class StatesFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes(Path.Combine("Data", "States.rxdata"));

        private readonly List<RxSharp.Rpg.State> _expectedInstance =
        [
            null,
            new RxSharp.Rpg.State { ID = 1, Name = "Knockout", AnimationID = 0, Restriction = 4, Nonresistance = false, ZeroHP = true, CantGetExp = true, CantEvade = false, SlipDamage = false, Rating = 10, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = false, HoldTurn = 0, AutoReleaseProb = 0, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }},
            new RxSharp.Rpg.State { ID = 2, Name = "Stun", AnimationID = 0, Restriction = 4, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 0, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 3, Name = "Venom", AnimationID = 91, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = true, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = false, HoldTurn = 0, AutoReleaseProb = 0, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 4, Name = "Dazzle", AnimationID = 92, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 5, HitRate = 20, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 2, AutoReleaseProb = 50, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 5, Name = "Mute", AnimationID = 93, Restriction = 1, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 2, AutoReleaseProb = 50, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 6, Name = "Confuse", AnimationID = 94, Restriction = 3, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 2, AutoReleaseProb = 50, ShockReleaseProb = 25, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 7, Name = "Sleep", AnimationID = 95, Restriction = 4, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = true, SlipDamage = false, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 2, AutoReleaseProb = 50, ShockReleaseProb = 50, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 8, Name = "Paralyze", AnimationID = 96, Restriction = 4, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 5, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 2, AutoReleaseProb = 25, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 9, Name = "Weaken", AnimationID = 0, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 4, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 50, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 4, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 10, Name = "Clumsy", AnimationID = 0, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 4, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 50, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 4, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 11, Name = "Delay", AnimationID = 0, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 4, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 50, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 4, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 12, Name = "Feeble", AnimationID = 0, Restriction = 0, Nonresistance = false, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 4, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 50, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 4, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 13, Name = "Sharp", AnimationID = 0, Restriction = 0, Nonresistance = true, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 3, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 150, PDefRate = 100, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 6, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 14, Name = "Barrier", AnimationID = 0, Restriction = 0, Nonresistance = true, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 3, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 150, MDefRate = 100, Eva = 0, BattleOnly = true, HoldTurn = 6, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 15, Name = "Resist", AnimationID = 0, Restriction = 0, Nonresistance = true, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 3, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 150, Eva = 0, BattleOnly = true, HoldTurn = 6, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.State { ID = 16, Name = "Blink", AnimationID = 0, Restriction = 0, Nonresistance = true, ZeroHP = false, CantGetExp = false, CantEvade = false, SlipDamage = false, Rating = 3, HitRate = 100, MaxHPRate = 100, MaxSPRate = 100, StrRate = 100, DexRate = 100, AgiRate = 100, IntRate = 100, AtkRate = 100, PDefRate = 100, MDefRate = 100, Eva = 100, BattleOnly = true, HoldTurn = 6, AutoReleaseProb = 100, ShockReleaseProb = 0, GuardElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() }
        ];

        [TestMethod]
        public void Read()
        {
            using (var ms = new MemoryStream(_rubyMarshalData))
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.State>>(ms);

                Assert.IsNotNull(results);
                Assert.IsTrue(results.Count == _expectedInstance.Count);

                for (var i = 0; i < results.Count; i++)
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects(expected, result);
                }
            }
        }

        private void CompareObjects(RxSharp.Rpg.State expectedValue, RxSharp.Rpg.State result)
        {
            if (expectedValue == null && result == null)
                return;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(RxSharp.Rpg.State));

            Assert.AreEqual(expectedValue.ID, result.ID, $"Mismatch in {nameof(expectedValue.ID)}");
            Assert.AreEqual(expectedValue.Name, result.Name, $"Mismatch in {nameof(expectedValue.Name)}");
            Assert.AreEqual(expectedValue.AnimationID, result.AnimationID, $"Mismatch in {nameof(expectedValue.AnimationID)}");
            Assert.AreEqual(expectedValue.Restriction, result.Restriction, $"Mismatch in {nameof(expectedValue.Restriction)}");
            Assert.AreEqual(expectedValue.Nonresistance, result.Nonresistance, $"Mismatch in {nameof(expectedValue.Nonresistance)}");
            Assert.AreEqual(expectedValue.ZeroHP, result.ZeroHP, $"Mismatch in {nameof(expectedValue.ZeroHP)}");
            Assert.AreEqual(expectedValue.CantGetExp, result.CantGetExp, $"Mismatch in {nameof(expectedValue.CantGetExp)}");
            Assert.AreEqual(expectedValue.CantEvade, result.CantEvade, $"Mismatch in {nameof(expectedValue.CantEvade)}");
            Assert.AreEqual(expectedValue.SlipDamage, result.SlipDamage, $"Mismatch in {nameof(expectedValue.SlipDamage)}");
            Assert.AreEqual(expectedValue.Rating, result.Rating, $"Mismatch in {nameof(expectedValue.Rating)}");
            Assert.AreEqual(expectedValue.HitRate, result.HitRate, $"Mismatch in {nameof(expectedValue.HitRate)}");
            Assert.AreEqual(expectedValue.MaxHPRate, result.MaxHPRate, $"Mismatch in {nameof(expectedValue.MaxHPRate)}");
            Assert.AreEqual(expectedValue.MaxSPRate, result.MaxSPRate, $"Mismatch in {nameof(expectedValue.MaxSPRate)}");
            Assert.AreEqual(expectedValue.StrRate, result.StrRate, $"Mismatch in {nameof(expectedValue.StrRate)}");
            Assert.AreEqual(expectedValue.DexRate, result.DexRate, $"Mismatch in {nameof(expectedValue.DexRate)}");
            Assert.AreEqual(expectedValue.AgiRate, result.AgiRate, $"Mismatch in {nameof(expectedValue.AgiRate)}");
            Assert.AreEqual(expectedValue.IntRate, result.IntRate, $"Mismatch in {nameof(expectedValue.IntRate)}");
            Assert.AreEqual(expectedValue.AtkRate, result.AtkRate, $"Mismatch in {nameof(expectedValue.AtkRate)}");
            Assert.AreEqual(expectedValue.PDefRate, result.PDefRate, $"Mismatch in {nameof(expectedValue.PDefRate)}");
            Assert.AreEqual(expectedValue.MDefRate, result.MDefRate, $"Mismatch in {nameof(expectedValue.MDefRate)}");
            Assert.AreEqual(expectedValue.Eva, result.Eva, $"Mismatch in {nameof(expectedValue.Eva)}");
            Assert.AreEqual(expectedValue.BattleOnly, result.BattleOnly, $"Mismatch in {nameof(expectedValue.BattleOnly)}");
            Assert.AreEqual(expectedValue.HoldTurn, result.HoldTurn, $"Mismatch in {nameof(expectedValue.HoldTurn)}");
            Assert.AreEqual(expectedValue.AutoReleaseProb, result.AutoReleaseProb, $"Mismatch in {nameof(expectedValue.AutoReleaseProb)}");
            Assert.AreEqual(expectedValue.ShockReleaseProb, result.ShockReleaseProb, $"Mismatch in {nameof(expectedValue.ShockReleaseProb)}");

            CollectionAssert.AreEqual(expectedValue.GuardElementSet, result.GuardElementSet, $"Mismatch in {nameof(expectedValue.GuardElementSet)}");
            CollectionAssert.AreEqual(expectedValue.PlusStateSet, result.PlusStateSet, $"Mismatch in {nameof(expectedValue.PlusStateSet)}");
            CollectionAssert.AreEqual(expectedValue.MinusStateSet, result.MinusStateSet, $"Mismatch in {nameof(expectedValue.MinusStateSet)}");
        }

        [TestMethod]
        public void Write()
        {
            byte[] writtenData;

            using (var memoryStream = new MemoryStream())
            {
                RmSerialiser.Serialise(memoryStream, _expectedInstance);

                writtenData = memoryStream.ToArray();

                Assert.AreEqual(writtenData.Length, _rubyMarshalData.Length);
            }

            using (var memoryStream2 = new MemoryStream(writtenData))
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.State>>(memoryStream2);

                Assert.IsNotNull(results);
                Assert.IsTrue(results.Count == _expectedInstance.Count);

                for (var i = 0; i < results.Count; i++)
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects(expected, result);
                }
            }

            var writePath = Path.Combine("Output", "States.rxdata");
            Directory.CreateDirectory("Output");
            File.WriteAllBytes(writePath, writtenData);
            Console.WriteLine(writePath);
        }
    }
}