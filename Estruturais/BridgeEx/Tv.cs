using System;

class Tv : IDevice
{
    public bool IsEnabled { get; set; }
    public int Volume { get; set; }
    public int Channel { get; set; }

    public void PrintStatus() =>
        Console.WriteLine($"TV -> Power: {(IsEnabled ? "On" : "Off")}, Vol: {Volume}, Ch: {Channel}");
}
