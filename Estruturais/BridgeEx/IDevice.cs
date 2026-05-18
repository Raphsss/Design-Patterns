using System;

interface IDevice
{
    bool IsEnabled { get; set; }
    int Volume { get; set; }
    int Channel { get; set; }
    void PrintStatus();
}
