using System;
using Patterns.Command.SimpleCommandImplementation;

namespace CommandP
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleRemoteControl = new SimpleRemoteControl();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            
            simpleRemoteControl.SetCommand(lightOnCommand);
            simpleRemoteControl.ButtonWasPressed();
        }
    }
}