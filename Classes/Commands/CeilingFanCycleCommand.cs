using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanCycleCommand : Command
    {
        private CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanCycleCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.Low();
                Console.WriteLine($"Ceiling Fan speed set to LOW");
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.High();
                Console.WriteLine($"Ceiling Fan speed set to HIGH");
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Medium();
                Console.WriteLine($"Ceiling Fan speed set to MEDIUM");
            }
            else
            {
                ceilingFan.Low();
                Console.WriteLine($"Ceiling Fan speed set to LOW");
            }
        }

        public void Undo()
        {
            prevSpeed = ceilingFan.GetSpeed();
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.Medium();
                Console.WriteLine("Undo: Ceiling Fan restored to MEDIUM.");
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Low();
                Console.WriteLine("Undo: Ceiling Fan restored to LOW.");
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.High();
                Console.WriteLine("Undo: Ceiling Fan restored to HIGH.");
            }
            else
            {
                ceilingFan.Off();
                Console.WriteLine("Undo: Ceiling Fan remains OFF.");
            }
        }
    }

}
