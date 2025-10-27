using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace CommandPattern.Classes.Commands
{
    internal class StereoCycleCommand : Command
    {
        private Stereo stereo;
        private Stack<string> undoStack; // Track history of stereo modes
        private string currentMode;      // Track current mode internally

        public StereoCycleCommand(Stereo stereo)
        {
            this.stereo = stereo;
            undoStack = new Stack<string>();
            currentMode = "CD"; // Start with CD mode by default
        }

        public void Execute()
        {
            // Save current mode for undo
            undoStack.Push(currentMode);

            // Cycle to the next mode
            switch (currentMode)
            {
                case "CD":
                    stereo.On();
                    stereo.SetDVD();
                    stereo.SetVolume(11);
                    currentMode = "DVD";
                    Console.WriteLine("Stereo set to DVD mode");
                    break;

                case "DVD":
                    stereo.On();
                    stereo.SetRadio();
                    stereo.SetVolume(11);
                    currentMode = "Radio";
                    Console.WriteLine("Stereo set to Radio mode");
                    break;

                case "Radio":
                default:
                    stereo.On();
                    stereo.SetCD();
                    stereo.SetVolume(11);
                    currentMode = "CD";
                    Console.WriteLine("Stereo set to CD mode");
                    break;
            }
        }

        public void Undo()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("Nothing to undo for Stereo.");
                return;
            }

            string lastMode = undoStack.Pop();

            switch (lastMode)
            {
                case "CD":
                    stereo.On();
                    stereo.SetCD();
                    stereo.SetVolume(11);
                    currentMode = "CD";
                    Console.WriteLine("Undo: Stereo restored to CD mode");
                    break;

                case "DVD":
                    stereo.On();
                    stereo.SetDVD();
                    stereo.SetVolume(11);
                    currentMode = "DVD";
                    Console.WriteLine("Undo: Stereo restored to DVD mode");
                    break;

                case "Radio":
                    stereo.On();
                    stereo.SetRadio();
                    stereo.SetVolume(11);
                    currentMode = "Radio";
                    Console.WriteLine("Undo: Stereo restored to Radio mode");
                    break;
            }
        }
    }
}
