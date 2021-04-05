using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Cyanide", "Encore", 2016, 450);
            MusicFile m2 = new MusicFile("Srotoshini", "Encore", 2017, 974);
            Phone phone = new MusicPlayer("Music Player", m1);
            phone.addMusic(m1, m2);
            phone.play(true);
            phone.playNext();

            Console.WriteLine();
            Console.WriteLine();

            Phone radio = new RadioPlayer("Radio Player", 55.02);
            radio.play(true);
            radio.playNext();
        }
    }
}
