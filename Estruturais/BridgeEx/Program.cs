var tv = new Tv { IsEnabled = false, Volume = 20, Channel = 1 };
var remote = new RemoteControl(tv);

remote.TogglePower();
remote.VolumeUp();
remote.ChannelUp();
remote.Print();

Console.WriteLine();

var radio = new Radio { IsEnabled = false, Volume = 5, Channel = 88 };
var advanced = new AdvancedRemote(radio);
advanced.TogglePower();
advanced.Mute();
advanced.Print();
