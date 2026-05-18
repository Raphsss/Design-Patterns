using System;

class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device) => this.device = device;

    public void TogglePower() => device.IsEnabled = !device.IsEnabled;
    public void VolumeUp() => device.Volume = Math.Min(100, device.Volume + 10);
    public void VolumeDown() => device.Volume = Math.Max(0, device.Volume - 10);
    public void ChannelUp() => device.Channel++;
    public void ChannelDown() => device.Channel--;

    public void Print() => device.PrintStatus();
}
