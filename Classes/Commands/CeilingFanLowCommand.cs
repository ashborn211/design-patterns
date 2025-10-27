using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;

        }

        public void Execute()
        {
            ceilingFan.Low();
            Console.WriteLine($"Ceiling Fan speed set to LOW");
        }

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
