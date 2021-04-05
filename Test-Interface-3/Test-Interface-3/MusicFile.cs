using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class MusicFile
    {
        public string tittle { get; set; }
        private string artist { get; }
        private int yearOfRelease { get; }
        private int durationInSeconds { get; }

        public MusicFile() { }

        public MusicFile(string tittle, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.tittle = tittle;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }

        void changeTittle(string tittle)
        {
            this.tittle = tittle;
        }

        public void showInfo()
        {
            Console.WriteLine("\tTittle: " + tittle);
            Console.WriteLine("\tArtist: " + artist);
            Console.WriteLine("\tRelease: " + yearOfRelease);
            Console.WriteLine("\tDuration: " + durationInSeconds);
        }

    }
}
