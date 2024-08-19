using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::AudioFile" )]
    public class AudioFile
    {
        [RmName( "name" )]
        public string Name { get; set; } = "";

        [RmName( "volume" )]
        public int Volume { get; set; } = 100;

        [RmName( "pitch" )]
        public int Pitch { get; set; } = 100;

        public AudioFile( )
        {
        }

        public AudioFile( string name, int volume = 100, int pitch = 100 )
        {
            Name = name;
            Volume = volume;
            Pitch = pitch;
        }
    }
}