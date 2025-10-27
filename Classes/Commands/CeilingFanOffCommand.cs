using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            // Record previous speed before turning off
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
            Console.WriteLine("Ceiling Fan turned OFF.");
        }

        public void Undo()
        {
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
                Console.WriteLine("Undo: Ceiling Fan restored to HIGH.");
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
                Console.WriteLine("Undo: Ceiling Fan restored to MEDIUM.");
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
                Console.WriteLine("Undo: Ceiling Fan restored to LOW.");
            }
            else
            {
                ceilingFan.Off();
                Console.WriteLine("Undo: Ceiling Fan remains OFF.");
            }
        }
    }
}
