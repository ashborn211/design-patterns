using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier amplifier;

        public Tuner(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off");
        }

        public void SetAM()
        {
            Console.WriteLine("Tuner set to AM mode");
        }

        public void SetFM()
        {
            Console.WriteLine("Tuner set to FM mode");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine("Tuner setting frequency to " + frequency);
        }
    }
}
