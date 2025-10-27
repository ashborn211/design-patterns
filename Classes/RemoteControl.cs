using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        private Command[] onCommands = new Command[6];
        private Command[] offCommands = new Command[6];
        private Command[] lastCommands = new Command[6]; // per-slot undo tracking

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
                lastCommands[i] = noCommand;
            }
            Console.WriteLine("RemoteControl initialized.");
        }

        // Assign commands to a slot
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
            Console.WriteLine($"Slot {slot} set: {onCommand.GetType().Name} / {offCommand.GetType().Name}");
        }

        // Executes ON command for the given slot
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            lastCommands[slot] = onCommands[slot]; // track last executed for that slot
            Console.WriteLine($"ON button pressed for slot {slot}");
        }

        // Executes OFF command for the given slot
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            lastCommands[slot] = offCommands[slot];
            Console.WriteLine($"OFF button pressed for slot {slot}");
        }

        // Undo only the last command executed in that slot
        public void UndoButtonWasPushed(int slot)
        {
            Console.WriteLine($"UNDO button pressed for slot {slot}...");
            lastCommands[slot].Undo(); //Calls the command’s Undo()
        }

        // Prints all slots and their assigned commands
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {onCommands[i].GetType().Name} \t {offCommands[i].GetType().Name}\n");
            }
            return sb.ToString();
        }
    }
}
