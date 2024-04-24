namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            TemperatureSensor sensor = new TemperatureSensor();
            TemperatureMonitor monitor = new TemperatureMonitor();

          
            monitor.StartMonitoring(sensor);

          
            sensor.CurrentTemperature = 20.5;
            sensor.CurrentTemperature = 22.0; 

            Console.ReadLine(); 
        }
    }
}
}
