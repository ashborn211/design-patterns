using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        private CeilingFan ceilingFan;

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
            ceilingFan.Off();
            Console.WriteLine("Undo: Ceiling Fan turned OFF.");
        }
    }
}
