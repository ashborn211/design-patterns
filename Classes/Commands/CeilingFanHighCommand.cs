using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        private CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.High();
            Console.WriteLine($"Ceiling Fan speed set to HIGH");
        }

        // Your request: Undo should just turn it OFF
        public void Undo()
        {
            prevSpeed = ceilingFan.GetSpeed();
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
