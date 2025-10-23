using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.High();
            prevSpeed = ceilingFan.GetSpeed();
            Console.WriteLine($"Ceiling Fan speed set to {ceilingFan.GetSpeed()}");
        }

        public void Undo()
        {
            ceilingFan.Off();
        }
    }
}
