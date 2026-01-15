namespace StaticExercise;

public class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        var conversion = (fahrenheit - 32) * 5 / 9;
        return conversion;
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}