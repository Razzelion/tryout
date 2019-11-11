using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            CelciusToFahrenheit(0); // Output: 32
            FahrenheitToCelcius(50); // Output: 10
            CelciusToKelvin(100); // Output: 373.15
            KelvinToCelcius(375); // Output: 101.85
            KelvinToFahrenheit(375); // Output: 215.33
            FahrenheitToKelvin(12); // Output: 262.039
        }

        private static double CelciusToFahrenheit(double value)
        {
            double fahrenheit;        
            Console.WriteLine("Celsius: " + value);
            fahrenheit = (value * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit + "\n");
            return 0;
        }

        private static double FahrenheitToCelcius(double value)
        {
            double celcius;        
            Console.WriteLine("Fahrenheit: " + value);
            celcius = (value-32) * 5/9;
            Console.WriteLine("Celcius: " + celcius + "\n");
            return 0;
        }

        private static double CelciusToKelvin(double value)
        {
            double kelvin;        
            Console.WriteLine("Celsius: " + value);
            kelvin = (value + 273.15);
            Console.WriteLine("Kelvin: " + kelvin + "\n");
            return 0;
        }

        private static double KelvinToCelcius(double value)
        {
            double celcius;        
            Console.WriteLine("Kelvin: " + value);
            celcius = (value - 273.15);
            Console.WriteLine("Celcius: " + celcius + "\n");
            return 0;
        }

        private static double KelvinToFahrenheit(double value)
        {
            double fahrenheit;        
            Console.WriteLine("Kelvin: " + value);
            fahrenheit = (value - 273.15)* 9/5 + 32;
            Console.WriteLine("fahrenheit: " + fahrenheit + "\n");
            return 0;
        }

        private static double FahrenheitToKelvin(double value)
        {
            double kelvin;        
            Console.WriteLine("Fahrenheit: " + value);
            kelvin = ((value-32) * 5/9)+273.15;
            Console.WriteLine("Kelvin: " + kelvin + "\n");
            return 0;
        }
    }
}
