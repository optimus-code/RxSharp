using RmSharp;
using RmSharp.Extensions;
using RmSharp.Tokens;
using RxSharp.Converters;
using RxSharp.Rpg;
using System.IO.Compression;
using System.Text;

namespace RxSharp.Tests
{
    [TestClass]
    public class ScriptsFile
    {
        private readonly byte[] _rubyMarshalData = File.ReadAllBytes( Path.Combine( "Data", "Scripts.rxdata" ) );

        private readonly List<Script> _expectedValue;

        public ScriptsFile( )
        {
            _expectedValue = System.Text.Json.JsonSerializer.Deserialize<List<Script>>( File.ReadAllBytes( Path.Combine( "Data", "Scripts.json" ) ) );

            foreach ( var script in _expectedValue )
            {
                script.Code = Encoding.UTF8.GetString( Convert.FromBase64String( script.Code ) );
            }
        }

        private void DumpScripts( )
        {
            //foreach ( var script in scripts )
            //{
            //    script.Code = Convert.ToBase64String( Encoding.UTF8.GetBytes( script.Code ) );
            //}

            //var json = System.Text.Json.JsonSerializer.Serialize( scripts );

            //File.WriteAllBytes( Path.Combine( "Data", "Scripts.json" ), Encoding.UTF8.GetBytes( json ) );
        }

        [TestMethod]
        public void Read( )
        {
            using ( var ms = new MemoryStream( _rubyMarshalData ) )
            using ( var reader = new BinaryReader( ms ) )
            {
                var converter = new ScriptConverter( );

                var scripts = converter.Read( reader );

                Assert.IsNotNull( scripts );
                Assert.IsTrue( scripts.Count == _expectedValue.Count );

                for ( var i = 0; i < scripts.Count; i++ )
                {
                    Assert.AreEqual( scripts[i].MagicNumber, _expectedValue[i].MagicNumber );
                    Assert.AreEqual( scripts[i].Name, _expectedValue[i].Name );
                    Assert.AreEqual( scripts[i].Code, _expectedValue[i].Code );
                }
            }
        }

        [TestMethod]
        public void Write( )
        {
            byte[] writtenData;

            var converter = new ScriptConverter( );

            using ( var memoryStream = new MemoryStream( ) )
            using ( var writer = new BinaryWriter( memoryStream ) )
            {
                converter.Write( writer, _expectedValue );

                writtenData = memoryStream.ToArray( );

                // ZLib defaults differ slightly but it doesn't seem to matter - results in a slightly different length
                //Assert.AreEqual( writtenData.Length, _rubyMarshalData.Length );
            }

            using ( var memoryStream2 = new MemoryStream( writtenData ) )
            using ( var reader = new BinaryReader( memoryStream2 ) )
            {
                var scripts = converter.Read( reader );

                Assert.IsNotNull( scripts );
                Assert.IsTrue( scripts.Count == _expectedValue.Count );

                for ( var i = 0; i < scripts.Count; i++ )
                {
                    Assert.AreEqual( scripts[i].MagicNumber, _expectedValue[i].MagicNumber );
                    Assert.AreEqual( scripts[i].Name, _expectedValue[i].Name );
                    Assert.AreEqual( scripts[i].Code, _expectedValue[i].Code );
                }
            }

            var writePath = Path.Combine( "Output", "Scripts.rxdata" );
            Directory.CreateDirectory( "Output" );
            File.WriteAllBytes( writePath, writtenData );
            Console.WriteLine( writePath );
        }
    }
}