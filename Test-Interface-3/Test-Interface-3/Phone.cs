using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Interface_3.Interfaces;

namespace Test_Interface_3 
{
    abstract class Phone : PlayerInterface
    {
        MusicFile [] musicFile;
        public int totalMusic { get; set; }

        public Phone()
        {
            musicFile = new MusicFile[500];
        }
        
        public void addMusic(params MusicFile [] musics)
        {
            if (totalMusic < 500)
            {
                foreach(MusicFile music in musics)
                {
                    this.musicFile[totalMusic++] = music;
                }
            }
            else
            {
                Console.WriteLine("This device cannot store more than 500 musicFile");
            }
        }

        public void musicList()
        {
            for(int i = 0; i < totalMusic; i++)
            {
                this.musicFile[i].showInfo();
            }
        }

        public void findMusic(string tittle)
        {
            foreach(var music in musicFile)
            {
                if (music.tittle.Equals(tittle))
                {
                    Console.WriteLine("Music Playing...");
                    music.showInfo();
                    break;
                }
            }
        }

        public void playNextSong(string tittle)
        {
            for(int i = 0; i < totalMusic; i++)
            {
                if (i < totalMusic)
                {
                    if (musicFile[i].tittle.Equals(tittle))
                    {
                        findMusic(musicFile[i+1].tittle);
                    }
                }
                else Console.WriteLine("Last Song");
            }
        }

        public void playPreviousSong(string tittle)
        {
            for (int i = 0; i < totalMusic; i++)
            {
                if (i >= 0)
                {
                    if (musicFile[i].tittle.Equals(tittle))
                    {
                        findMusic(musicFile[i-1].tittle);
                    }
                }
                else Console.WriteLine("First Song");
            }
        }

        public abstract void Switch(bool on);
        public abstract void setVolume(int loudness);
        public abstract void play(bool on);
        public abstract void playNext();
        public abstract void playPrevious();
    }
}
