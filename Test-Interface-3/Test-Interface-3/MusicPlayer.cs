using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Interface_3.Interfaces;

namespace Test_Interface_3
{
    class MusicPlayer : Phone, PlayerInterface, MusicPlayerInterface
    {
        public string PlayerName { get; set; }
        MusicFile music { get; set; }
        public MusicPlayer(string PlayerName, MusicFile music)
        {
            this.PlayerName = PlayerName;
            this.music = music;
        }

        public override void Switch(bool on)
        {
            if (on)
            {
                base.findMusic(music.tittle);
            }
            else Console.WriteLine("Resume music");
        }

        public override void setVolume(int loudness)
        {
            
        }

        public override void play(bool on)
        {
            if (on)
            {
                findMusic(music.tittle);
            }
            else Console.WriteLine("Resume music");
        }

        public override void playNext()
        {
            playNextSong(music.tittle);
        }

        public override void playPrevious()
        {
            playPreviousSong(music.tittle);
        }
    }
}
