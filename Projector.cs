using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector in TV mode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode");
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector input set to DVD Player");
        }
    }
}

