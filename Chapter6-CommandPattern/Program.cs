using CommandPattern;

/* SimpleRemoteControl remote = new();

Light light= new();
GarageDoor garageDoor= new();

LightOnCommand lightOn= new (light);
GarageDoorOpenCommand garageDoorOpen = new (garageDoor);


remote.SetCommand(lightOn);
remote.PressTheButton();

remote.SetCommand(garageDoorOpen);
remote.PressTheButton(); */

RemoteControl remote = new(7);

Light livingRoomLight = new();
Light kitchenLight = new();
GarageDoor garageDoor = new();
Stereo stereo = new();

LightOnCommand livingRoomLightOn = new(livingRoomLight);
LightOffCommand livingRoomLightOff = new(livingRoomLight);

LightOnCommand kitchenLightOn = new(kitchenLight);
LightOffCommand kitchenLightOff = new(kitchenLight);

GarageDoorOpenCommand garageDoorOpen = new(garageDoor);
GarageDoorCloseCommand garageDoorClose = new(garageDoor);

StereoOnWithCDCommand stereoOnWithCD = new(stereo);
StereoOffCommand stereoOff = new(stereo);

remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
remote.SetCommand(2, garageDoorOpen, garageDoorClose);
remote.SetCommand(3, stereoOnWithCD, stereoOff);

System.Console.WriteLine(remote);

for (int i = 0; i < remote.NumberOfSlots; i++)
{
    remote.PressOnButton(i);
    remote.PressOffButton(i);
}

System.Console.WriteLine();
System.Console.WriteLine("Testing the UNDO functionality...");
System.Console.WriteLine();

remote.PressOnButton(0);
remote.PressOffButton(0);

System.Console.WriteLine(remote);
remote.PressUndoButton();

remote.PressOffButton(0);
remote.PressOnButton(0);

System.Console.WriteLine(remote);
remote.PressUndoButton();

CeilingFan fan = new("Living Room");
CeilingFanHighCommand ceilingFanHigh = new(fan);
CeilingFanOffCommand ceilingFanOff = new(fan);

remote.SetCommand(4, ceilingFanHigh, ceilingFanOff);

remote.PressOnButton(4);
remote.PressOffButton(4);

System.Console.WriteLine(remote);

remote.PressUndoButton();

System.Console.WriteLine(remote);

remote.PressUndoButton();

ICommand[] macroOn = [livingRoomLightOn, kitchenLightOn, stereoOnWithCD];
ICommand[] macroOff = [livingRoomLightOff, kitchenLightOff, stereoOff];

MacroCommand macroCommandOn = new(macroOn);
MacroCommand macroCommandOff = new(macroOff);

remote.SetCommand(5, macroCommandOn, macroCommandOff);

System.Console.WriteLine("======== Pushing Macro On ========");
remote.PressOnButton(5);

System.Console.WriteLine("======== Pushing Macro Off ========");
remote.PressOffButton(5);