using System;


namespace Events
{
   

    public class TemperatureMonitor
    {
        public void StartMonitoring(TemperatureSensor sensor)
        {
           
            sensor.TemperatureChanged += Sensor_TemperatureChanged;
        }

        private void Sensor_TemperatureChanged(object sender, TemperatureChangedEventArgs args)
        {
            Console.WriteLine($"Temperature changed: {args.NewTemperature}°C");
            
        }
    }
}
