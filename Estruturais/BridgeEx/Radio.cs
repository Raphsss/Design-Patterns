using System;

class Radio : IDevice
{
    public bool IsEnabled { get; set; }
    public int Volume { get; set; }
    public int Channel { get; set; }

    public void PrintStatus() =>
        Console.WriteLine($"Radio -> Power: {(IsEnabled ? "On" : "Off")}, Vol: {Volume}, Station: {Channel}");
}
