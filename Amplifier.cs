using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner tuner;
        private DvdPlayer dvdPlayer;
        private CdPlayer cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this.cdPlayer = cdPlayer;
            Console.WriteLine("Amplifier setting CD player");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier setting DVD player");
        }

        public void SetTuner(Tuner tuner)
        {
            this.tuner = tuner;
            Console.WriteLine("Amplifier setting tuner");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier stereo sound on (2 speakers)");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier setting volume to " + volume);
        }
    }
}
