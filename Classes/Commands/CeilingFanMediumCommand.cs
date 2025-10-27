using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.Medium();
            Console.WriteLine($"Ceiling Fan speed set to MEDIUM");
        }

        public void Undo()
        {   
            ceilingFan.Off();
            Console.WriteLine("Undo: Ceiling Fan turned OFF.");
        }
    }
}
