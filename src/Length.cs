namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of length measurement. The base unit is meters.
/// </summary>
public static class Length
{
    /// <summary>
    /// Gets the meter unit.
    /// </summary>
    public static IUnit Meters { get; } = new LengthUnit("Meter", "m", 1.0);

    /// <summary>
    /// Gets the kilometer unit.
    /// </summary>
    public static IUnit Kilometers { get; } = new LengthUnit("Kilometer", "km", 1000.0);

    /// <summary>
    /// Gets the centimeter unit.
    /// </summary>
    public static IUnit Centimeters { get; } = new LengthUnit("Centimeter", "cm", 0.01);

    /// <summary>
    /// Gets the millimeter unit.
    /// </summary>
    public static IUnit Millimeters { get; } = new LengthUnit("Millimeter", "mm", 0.001);

    /// <summary>
    /// Gets the inch unit.
    /// </summary>
    public static IUnit Inches { get; } = new LengthUnit("Inch", "in", 0.0254);

    /// <summary>
    /// Gets the foot unit.
    /// </summary>
    public static IUnit Feet { get; } = new LengthUnit("Foot", "ft", 0.3048);

    /// <summary>
    /// Gets the yard unit.
    /// </summary>
    public static IUnit Yards { get; } = new LengthUnit("Yard", "yd", 0.9144);

    /// <summary>
    /// Gets the mile unit.
    /// </summary>
    public static IUnit Miles { get; } = new LengthUnit("Mile", "mi", 1609.344);

    private sealed class LengthUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public LengthUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
