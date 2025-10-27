using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        private Command[] onCommands = new Command[7];
        private Command[] offCommands = new Command[7];

        private Stack<Command> undoStack = new Stack<Command>(); 
        //holds the on and off commands for each slot
        //stack is like a array that can only add and remove from the top
        //(ik ga dit 100% vergeten als je wilt dat ik dit uitleg)

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
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
            Console.WriteLine($"ON button pressed for slot {slot}");
            onCommands[slot].Execute();
            undoStack.Push(onCommands[slot]); // push executed command to undo stack
        }

        // Executes OFF command for the given slot
        public void OffButtonWasPushed(int slot)
        {
            Console.WriteLine($"OFF button pressed for slot {slot}");
            offCommands[slot].Execute();
            undoStack.Push(offCommands[slot]); // push executed command to undo stack
        }

        // Undo the last executed command (from stack)
        public void UndoButtonWasPushed()
        {
            if (undoStack.Count > 0)
            {
                Command lastCommand = undoStack.Pop();
                Console.WriteLine("UNDO button pressed...");
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
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
