using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;


        // Single instance
        private volatile static ChocolateBoiler instance;


        // Lock object for thread safety
        private static readonly object lockObject = new object();


        // Private constructor
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        // Public method to get the single instance
        public static ChocolateBoiler GetInstance()
        {
            if (instance == null) // 1st check
            {
                lock (lockObject) // Only one thread at a time can enter
                {
                    if (instance == null) // 2nd check inside lock
                    {
                        instance = new ChocolateBoiler(); // Create the single instance
                    }
                }
            }
            return instance; // Return the singleton instance
        }

        public void Fill()
        {
            if (empty)
            {

                empty = false;
                boiled = false;
                Console.WriteLine("Boiler filled.");
            }
        }

        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boiler boiled.");
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Boiler drained.");
            }
        }
    }
}

