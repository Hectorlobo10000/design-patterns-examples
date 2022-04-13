using System;
using Patterns.Command.ComplexCommandImplementation;

// the command pattern encapsulates a request as an object, thereby letting you parameterize
// other objects with different requests, queue or log requests, and support undoable operations.

namespace CommandP
{
    class Program
    {
        static void Main(string[] args)
        {
            // var simpleRemoteControl = new SimpleRemoteControl();
            // var light = new Light();
            // var lightOnCommand = new LightOnCommand(light);
            //
            // simpleRemoteControl.SetCommand(lightOnCommand);
            // simpleRemoteControl.ButtonWasPressed();

            var remoteControl = new RemoteControl();
            var livingRoomLight = new Light("living room");
            var kitchenLight = new Light("kitchen");

            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            var livinRoomLightOffCommand = new LightOffCommand(livingRoomLight);

            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);
            
            remoteControl.SetCommand(0, livingRoomLightOnCommand, livinRoomLightOffCommand);
            remoteControl.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);

            Console.WriteLine(remoteControl);
            
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

        }
    }
}