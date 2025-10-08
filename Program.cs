namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cd = new CdPlayer(amp);
            DvdPlayer dvd = new DvdPlayer(amp);
            Tuner tuner = new Tuner(amp);
            PopcornPopper popper = new PopcornPopper();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Projector projector = new Projector(dvd);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp, tuner, dvd, cd, projector, lights, screen, popper
            );

            homeTheater.WatchMovie("Sonic the Hedgehog");
            homeTheater.EndMovie();

            Console.ReadLine();
        }
    }
}
