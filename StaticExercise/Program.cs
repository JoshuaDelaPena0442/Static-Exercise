namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(28.0);
            var celsius = TempConverter.FahrenheitToCelsius(29.0);
            
            Console.WriteLine($"Celsius: {celsius}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}
