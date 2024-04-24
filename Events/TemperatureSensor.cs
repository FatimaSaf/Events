using System;

public class TemperatureSensor
{
   
    public delegate void TemperatureChangedEventHandler(object sender, TemperatureChangedEventArgs args);

  
    public event TemperatureChangedEventHandler TemperatureChanged;

    private double currentTemperature;

    public double CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            if (currentTemperature != value)
            {
                currentTemperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}