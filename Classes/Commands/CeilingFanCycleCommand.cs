using System;
using System.Collections.Generic;
using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanCycleCommand : Command
    {
        private CeilingFan ceilingFan;
        private Stack<int> speedHistory; // Stack to track previous speeds

        public CeilingFanCycleCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
            speedHistory = new Stack<int>();
        }

        public void Execute()
        {
            int currentSpeed = ceilingFan.GetSpeed();
            speedHistory.Push(currentSpeed); // save current speed for undo

            // Cycle to the next speed
            switch (currentSpeed)
            {
                case 3: // HIGH
                    ceilingFan.Low();
                    Console.WriteLine("Ceiling Fan speed set to LOW");
                    break;
                case 1: // LOW
                    ceilingFan.Medium();
                    Console.WriteLine("Ceiling Fan speed set to MEDIUM");
                    break;
                case 2: // MEDIUM
                    ceilingFan.High();
                    Console.WriteLine("Ceiling Fan speed set to HIGH");
                    break;
                default:
                    ceilingFan.Low();
                    Console.WriteLine("Ceiling Fan speed set to LOW");
                    break;
            }
        }

        public void Undo()
        {
            if (speedHistory.Count == 0)
            {
                Console.WriteLine("Nothing to undo for Ceiling Fan.");
                return;
            }

            int lastSpeed = speedHistory.Pop();

            switch (lastSpeed)
            {
                case 1: // LOW
                    ceilingFan.Low();
                    Console.WriteLine("Undo: Ceiling Fan restored to LOW");
                    break;
                case 2: // MEDIUM
                    ceilingFan.Medium();
                    Console.WriteLine("Undo: Ceiling Fan restored to MEDIUM");
                    break;
                case 3: // HIGH
                    ceilingFan.High();
                    Console.WriteLine("Undo: Ceiling Fan restored to HIGH");
                    break;
                default:
                    ceilingFan.Low();
                    Console.WriteLine("Undo: Ceiling Fan restored to LOW");
                    break;
            }
        }
    }
}
