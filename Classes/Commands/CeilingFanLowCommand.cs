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
            ceilingFan.Off();
            Console.WriteLine("Undo: Ceiling Fan turned OFF.");
        }
    }
}
