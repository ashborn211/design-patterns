using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        public class HomeTheaterFacade
        {
            private Amplifier amp;
            private Tuner tuner;
            private DvdPlayer dvd;
            private CdPlayer cd;
            private Projector projector;
            private TheaterLights lights;
            private Screen screen;
            private PopcornPopper popper;

            public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector,
                                     TheaterLights lights, Screen screen, PopcornPopper popper)
            {
                this.amp = amp;
                this.tuner = tuner;
                this.dvd = dvd;
                this.cd = cd;
                this.projector = projector;
                this.lights = lights;
                this.screen = screen;
                this.popper = popper;
            }

        }
    }
