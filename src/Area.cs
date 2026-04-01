namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of area measurement. The base unit is square meters.
/// </summary>
public static class Area
{
    /// <summary>
    /// Gets the square meter unit.
    /// </summary>
    public static IUnit SquareMeters { get; } = new AreaUnit("Square Meter", "m\u00b2", 1.0);

    /// <summary>
    /// Gets the square kilometer unit.
    /// </summary>
    public static IUnit SquareKilometers { get; } = new AreaUnit("Square Kilometer", "km\u00b2", 1000000.0);

    /// <summary>
    /// Gets the square foot unit.
    /// </summary>
    public static IUnit SquareFeet { get; } = new AreaUnit("Square Foot", "ft\u00b2", 0.09290304);

    /// <summary>
    /// Gets the square yard unit.
    /// </summary>
    public static IUnit SquareYards { get; } = new AreaUnit("Square Yard", "yd\u00b2", 0.83612736);

    /// <summary>
    /// Gets the acre unit.
    /// </summary>
    public static IUnit Acres { get; } = new AreaUnit("Acre", "ac", 4046.8564224);

    /// <summary>
    /// Gets the hectare unit.
    /// </summary>
    public static IUnit Hectares { get; } = new AreaUnit("Hectare", "ha", 10000.0);

    private sealed class AreaUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public AreaUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
