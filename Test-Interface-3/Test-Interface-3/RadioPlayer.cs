using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Interface_3.Interfaces;

namespace Test_Interface_3
{
    class RadioPlayer : Phone, PlayerInterface, RadioPlayerInterface
    {
        public string playerName { get; set; }
        public double channel { get; set; }

        public RadioPlayer(string playerName, double channel)
        {
            this.playerName = playerName;
            this.channel = channel;
        }


        public void changeChanel()
        {
        }

        public override void play(bool on)
        {
            Console.WriteLine("Radio Playing...");
            showInfo();
        }

        public override void playNext()
        {
            if (channel <= 99.79)
            {
                channel += 0.20;
            }
            else Console.WriteLine("Cannot going next");
            showInfo();
        }

        public override void playPrevious()
        {
            if (channel >= 0.20)
            {
                channel -= 0.20;
            }
            else Console.WriteLine("Cannot going previous");
            showInfo();
        }

        public void reTune(double frequency)
        {
        }

        public override void setVolume(int loudness)
        {
            Console.WriteLine("Volume: " + loudness);
        }

        public override void Switch(bool on)
        {
            Console.WriteLine("Radio Playing...");
            showInfo();
        }

        public void showInfo()
        {
            Console.WriteLine("\tChannel: " + channel);
        }
    }
}
