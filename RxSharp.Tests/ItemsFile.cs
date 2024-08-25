using RmSharp;

namespace RxSharp.Tests
{
    [TestClass]
    public class ItemsFIle
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Items.rxdata" ) );

        private readonly List<RxSharp.Rpg.Item> _expectedInstance = new List<RxSharp.Rpg.Item>
        {
            null,
            new RxSharp.Rpg.Item { ID = 1, Name = "Potion", IconName = "021-Potion01", Description = "Restores HP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 15, MenuSE = new RxSharp.Rpg.AudioFile { Name = "105-Heal01", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 50, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 500, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 2, Name = "High Potion", IconName = "021-Potion01", Description = "Restores HP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 16, MenuSE = new RxSharp.Rpg.AudioFile { Name = "106-Heal02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 150, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 2000, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 3, Name = "Full Potion", IconName = "021-Potion01", Description = "Restores HP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 17, MenuSE = new RxSharp.Rpg.AudioFile { Name = "107-Heal03", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 450, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 9999, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 4, Name = "Perfume", IconName = "022-Potion02", Description = "Restores SP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 18, MenuSE = new RxSharp.Rpg.AudioFile { Name = "108-Heal04", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 100, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 500, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 5, Name = "High Perfume", IconName = "022-Potion02", Description = "Restores SP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 19, MenuSE = new RxSharp.Rpg.AudioFile { Name = "109-Heal05", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 300, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 2000, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 6, Name = "Full Perfume", IconName = "022-Potion02", Description = "Restores SP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 20, MenuSE = new RxSharp.Rpg.AudioFile { Name = "110-Heal06", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 900, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 9999, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 7, Name = "Elixir", IconName = "023-Potion03", Description = "Restores HP/SP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 21, MenuSE = new RxSharp.Rpg.AudioFile { Name = "111-Heal07", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 600, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 2000, RecoverSPRate = 0, RecoverSP = 2000, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 8, Name = "Full Elixir", IconName = "023-Potion03", Description = "Restores HP/SP to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 22, MenuSE = new RxSharp.Rpg.AudioFile { Name = "112-Heal08", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 1200, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 9999, RecoverSPRate = 0, RecoverSP = 9999, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 9, Name = "Tonic", IconName = "024-Potion04", Description = "Revives one ally.", Scope = 5, Occasion = 0, Animation1ID = 3, Animation2ID = 25, MenuSE = new RxSharp.Rpg.AudioFile { Name = "115-Raise01", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 150, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 50, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int> { 1 } },
            new RxSharp.Rpg.Item { ID = 10, Name = "Full Tonic", IconName = "024-Potion04", Description = "Revives one ally.", Scope = 5, Occasion = 0, Animation1ID = 3, Animation2ID = 26, MenuSE = new RxSharp.Rpg.AudioFile { Name = "116-Raise02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 350, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 100, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int> { 1 } },
            new RxSharp.Rpg.Item { ID = 11, Name = "Antidote", IconName = "025-Herb01", Description = "Removes Venom state of one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 23, MenuSE = new RxSharp.Rpg.AudioFile { Name = "113-Remedy01", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 40, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int> { 3 } },
            new RxSharp.Rpg.Item { ID = 12, Name = "Dispel Herb", IconName = "026-Herb02", Description = "Restores states to one ally.", Scope = 3, Occasion = 0, Animation1ID = 3, Animation2ID = 24, MenuSE = new RxSharp.Rpg.AudioFile { Name = "114-Remedy02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 120, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int> { 3, 4, 5, 6, 7, 8 } },
            new RxSharp.Rpg.Item { ID = 13, Name = "Sharp Stone", IconName = "035-Item04", Description = "Up ATK of all allies.", Scope = 4, Occasion = 1, Animation1ID = 3, Animation2ID = 63, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int> { 13 }, MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 14, Name = "Barrier Stone", IconName = "035-Item04", Description = "Up PDEF of all allies.", Scope = 4, Occasion = 1, Animation1ID = 3, Animation2ID = 64, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int> { 14 }, MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 15, Name = "Resist Stone", IconName = "035-Item04", Description = "Up MDEF of all allies.", Scope = 4, Occasion = 1, Animation1ID = 3, Animation2ID = 65, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int> { 15 }, MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 16, Name = "Blink Stone", IconName = "035-Item04", Description = "Up EVA of all allies.", Scope = 4, Occasion = 1, Animation1ID = 3, Animation2ID = 66, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int> { 16 }, MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 17, Name = "Seed of Life", IconName = "042-Item11", Description = "Increases 50 MaxHP of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 1, ParameterPoints = 50, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 18, Name = "Seed of Mana", IconName = "042-Item11", Description = "Increases 50 MaxSP of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 2, ParameterPoints = 50, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 19, Name = "Seed of Strength", IconName = "042-Item11", Description = "Increases 5 STR of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 3, ParameterPoints = 5, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 20, Name = "Seed of Dextality", IconName = "042-Item11", Description = "Increases 5 DEX of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 4, ParameterPoints = 5, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 21, Name = "Seed of Agility", IconName = "042-Item11", Description = "Increases 5 AGI of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 5, ParameterPoints = 5, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 22, Name = "Seed of Intelligence", IconName = "042-Item11", Description = "Increases 5 INT of one ally.", Scope = 3, Occasion = 2, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "056-Right02", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 200, Consumable = true, ParameterType = 6, ParameterPoints = 5, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 23, Name = "Door Key", IconName = "029-Key01", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 24, Name = "Chest Key", IconName = "029-Key01", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 25, Name = "Jail Key", IconName = "029-Key01", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 26, Name = "Pouch", IconName = "032-Item01", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 27, Name = "Letter", IconName = "033-Item02", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 28, Name = "Feather", IconName = "037-Item06", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 29, Name = "Map", IconName = "038-Item07", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 30, Name = "Lithograph", IconName = "039-Item08", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 31, Name = "Card", IconName = "040-Item09", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() },
            new RxSharp.Rpg.Item { ID = 32, Name = "Fruit", IconName = "041-Item10", Description = "Event Item.", Scope = 0, Occasion = 3, Animation1ID = 0, Animation2ID = 0, MenuSE = new RxSharp.Rpg.AudioFile { Name = "", Volume = 80, Pitch = 100 }, CommonEventID = 0, Price = 0, Consumable = true, ParameterType = 0, ParameterPoints = 0, RecoverHPRate = 0, RecoverHP = 0, RecoverSPRate = 0, RecoverSP = 0, Hit = 100, PDefF = 0, MDefF = 0, Variance = 0, ElementSet = new List<int>(), PlusStateSet = new List<int>(), MinusStateSet = new List<int>() }
        };


        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Item>>( ms );

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

        private void CompareObjects( RxSharp.Rpg.Item expectedValue, RxSharp.Rpg.Item result )
        {
            if ( expectedValue == null && result == null )
                return;

            Assert.IsNotNull( result );
            Assert.IsInstanceOfType( result, typeof( RxSharp.Rpg.Item ) );

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
            Assert.AreEqual( expectedValue.Price, result.Price, $"Mismatch in {nameof( expectedValue.Price )}" );
            Assert.AreEqual( expectedValue.Consumable, result.Consumable, $"Mismatch in {nameof( expectedValue.Consumable )}" );
            Assert.AreEqual( expectedValue.ParameterType, result.ParameterType, $"Mismatch in {nameof( expectedValue.ParameterType )}" );
            Assert.AreEqual( expectedValue.ParameterPoints, result.ParameterPoints, $"Mismatch in {nameof( expectedValue.ParameterPoints )}" );
            Assert.AreEqual( expectedValue.RecoverHPRate, result.RecoverHPRate, $"Mismatch in {nameof( expectedValue.RecoverHPRate )}" );
            Assert.AreEqual( expectedValue.RecoverHP, result.RecoverHP, $"Mismatch in {nameof( expectedValue.RecoverHP )}" );
            Assert.AreEqual( expectedValue.RecoverSPRate, result.RecoverSPRate, $"Mismatch in {nameof( expectedValue.RecoverSPRate )}" );
            Assert.AreEqual( expectedValue.RecoverSP, result.RecoverSP, $"Mismatch in {nameof( expectedValue.RecoverSP )}" );
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

                Assert.AreEqual( _rubyMarshalData.Length, writtenData.Length );
            }

            using ( var memoryStream2 = new MemoryStream( writtenData ) )
            {
                var results = RmSerialiser.Deserialise<List<RxSharp.Rpg.Item>>( memoryStream2 );

                Assert.IsNotNull( results );
                Assert.IsTrue( results.Count == _expectedInstance.Count );

                for ( var i = 0; i < results.Count; i++ )
                {
                    var expected = _expectedInstance[i];
                    var result = results[i];
                    CompareObjects( expected, result );
                }
            }

            var writePath = Path.Combine( "Output", "Items.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}