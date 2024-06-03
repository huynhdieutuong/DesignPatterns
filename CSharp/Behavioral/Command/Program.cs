using Command.Base;
using Command.CeilingFan;
using Command.GarageDoor;
using Command.Light;
using Command.Stereo;

SimpleRemoteControl simpleRemoteControl = new();
Light light = new("light");
LightOnCommand lightOn = new(light);
simpleRemoteControl.SetCommand(lightOn);
simpleRemoteControl.ButtonWasPressed();

Console.WriteLine("=================");

RemoteControl remote = new();

Light livingLight = new("Living Room light");
LightOnCommand livingLightOn = new(livingLight);
LightOffCommand livingLightOff = new(livingLight);

Light kitchenLight = new("Kitchen light");
LightOnCommand kitchenLightOn = new(kitchenLight);
LightOffCommand kitchenLightOff = new(kitchenLight);

GarageDoor garageDoor = new();
GarageDoorUpCommand garageUp = new(garageDoor);
GarageDoorDownCommand garageDown = new(garageDoor);

CeilingFan livingCeilingFan = new("Living Room");
CeilingFanMediumCommand livingCeilingFanMedium = new(livingCeilingFan);
CeilingFanHighCommand livingCeilingFanHigh = new(livingCeilingFan);
CeilingFanOffCommand livingCeilingFanOff = new(livingCeilingFan);

Stereo livingStereo = new("Living Room stereo");
StereoOnWithCDCommand livingStereoOnWithCD = new(livingStereo);
StereoOffCommand livingStereoOff = new(livingStereo);

//remote.SetCommand(0, livingLightOn, livingLightOff);
//remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
//remote.SetCommand(2, livingStereoOnWithCD, livingStereoOff);
remote.SetCommand(3, livingCeilingFanMedium, livingCeilingFanOff);
remote.SetCommand(4, livingCeilingFanHigh, livingCeilingFanOff);

//Console.WriteLine(remote);
//remote.OnButtonWasPushed(0);
//remote.OffButtonWasPushed(0);
//remote.OnButtonWasPushed(1);
//remote.OffButtonWasPushed(1);
//remote.OnButtonWasPushed(2);
//remote.OffButtonWasPushed(2);
//remote.OnButtonWasPushed(3);
//remote.OffButtonWasPushed(3);

remote.OnButtonWasPushed(3);
remote.OffButtonWasPushed(3);

Console.WriteLine(remote);

remote.UndoButtonWasPushed();
remote.OnButtonWasPushed(4);

Console.WriteLine(remote);

remote.UndoButtonWasPushed();

Console.WriteLine("========================");
ICommand[] partyOn = { livingLightOn, livingCeilingFanHigh, livingStereoOnWithCD };
ICommand[] partyOff = { livingLightOff, livingCeilingFanOff, livingStereoOff };

MacroCommand partyOnMacro = new(partyOn);
MacroCommand partyOffMacro = new(partyOff);
remote.SetCommand(5, partyOnMacro, partyOffMacro);
Console.WriteLine(remote);
Console.WriteLine("---Pushing Macro On---");
remote.OnButtonWasPushed(5);
Console.WriteLine("---Pushing Macro Off---");
remote.OffButtonWasPushed(5);
Console.WriteLine("---Pushing Macro Undo---");
remote.UndoButtonWasPushed();