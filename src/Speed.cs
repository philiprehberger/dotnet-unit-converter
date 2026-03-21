namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of speed measurement. The base unit is meters per second.
/// </summary>
public static class Speed
{
    /// <summary>
    /// Gets the meters per second unit.
    /// </summary>
    public static IUnit MetersPerSecond { get; } = new SpeedUnit("Meters per second", "m/s", 1.0);

    /// <summary>
    /// Gets the kilometers per hour unit.
    /// </summary>
    public static IUnit KilometersPerHour { get; } = new SpeedUnit("Kilometers per hour", "km/h", 1.0 / 3.6);

    /// <summary>
    /// Gets the miles per hour unit.
    /// </summary>
    public static IUnit MilesPerHour { get; } = new SpeedUnit("Miles per hour", "mph", 0.44704);

    /// <summary>
    /// Gets the knot unit.
    /// </summary>
    public static IUnit Knots { get; } = new SpeedUnit("Knot", "kn", 0.514444);

    private sealed class SpeedUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public SpeedUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
