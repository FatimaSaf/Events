using System;

public class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}