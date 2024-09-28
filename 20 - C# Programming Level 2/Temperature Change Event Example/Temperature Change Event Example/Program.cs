using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{
    public class TemperatureChangedEventArgs:EventArgs
    {
        public double OldTemperature {  get;  }
        public double NewTemperature { get; }
        public double Diffrence {  get; }

        public TemperatureChangedEventArgs(double OldTemperature, double NewTemperature)
        {
            this.OldTemperature = OldTemperature;
            this.NewTemperature = NewTemperature;
            this.Diffrence = NewTemperature - OldTemperature;
        }
    }

    public class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> OnTemperatureChanged;
        private double OldTemperature;
        private double CurrentTemperature;
        public void SetTemperature(double NewTemperature)
        {
            if(CurrentTemperature!=NewTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = NewTemperature;
                RaiseOnTemperatureChanged(OldTemperature, NewTemperature);
            }

        }
        private void RaiseOnTemperatureChanged(double OldTemperature, double NewTemperature)
        {
            RaiseOnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature, NewTemperature));
        }
        protected virtual void RaiseOnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            OnTemperatureChanged?.Invoke(this, e);
        }
    }

    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.OnTemperatureChanged += HandleTemperatureChanged;
        }
        public void HandleTemperatureChanged(object sender,TemperatureChangedEventArgs e)
        {
            Console.WriteLine("\n\nTemperature Changed : ");
            Console.WriteLine($"Temperature Changed From {e.OldTemperature} C");
            Console.WriteLine($"Temperature Changed To {e.NewTemperature} C");
            Console.WriteLine($"Temperature Diffrence To {e.Diffrence} C");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Display display = new Display();

            display.Subscribe(thermostat);
            thermostat.SetTemperature(25);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(30);
            Console.ReadKey();
        }
    }
}
