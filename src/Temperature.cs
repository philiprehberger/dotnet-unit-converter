namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of temperature measurement. The base unit is Celsius.
/// </summary>
public static class Temperature
{
    /// <summary>
    /// Gets the Celsius unit.
    /// </summary>
    public static IUnit Celsius { get; } = new CelsiusUnit();

    /// <summary>
    /// Gets the Fahrenheit unit.
    /// </summary>
    public static IUnit Fahrenheit { get; } = new FahrenheitUnit();

    /// <summary>
    /// Gets the Kelvin unit.
    /// </summary>
    public static IUnit Kelvin { get; } = new KelvinUnit();

    private sealed class CelsiusUnit : IUnit
    {
        public string Name => "Celsius";
        public string Symbol => "\u00B0C";

        public double ToBase(double value) => value;
        public double FromBase(double value) => value;
    }

    private sealed class FahrenheitUnit : IUnit
    {
        public string Name => "Fahrenheit";
        public string Symbol => "\u00B0F";

        public double ToBase(double value) => (value - 32.0) * 5.0 / 9.0;
        public double FromBase(double value) => value * 9.0 / 5.0 + 32.0;
    }

    private sealed class KelvinUnit : IUnit
    {
        public string Name => "Kelvin";
        public string Symbol => "K";

        public double ToBase(double value) => value - 273.15;
        public double FromBase(double value) => value + 273.15;
    }
}
