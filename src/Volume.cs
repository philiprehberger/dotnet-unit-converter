namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of volume measurement. The base unit is liters.
/// </summary>
public static class Volume
{
    /// <summary>
    /// Gets the liter unit.
    /// </summary>
    public static IUnit Liters { get; } = new VolumeUnit("Liter", "L", 1.0);

    /// <summary>
    /// Gets the milliliter unit.
    /// </summary>
    public static IUnit Milliliters { get; } = new VolumeUnit("Milliliter", "mL", 0.001);

    /// <summary>
    /// Gets the US gallon unit.
    /// </summary>
    public static IUnit Gallons { get; } = new VolumeUnit("Gallon", "gal", 3.785411784);

    /// <summary>
    /// Gets the US quart unit.
    /// </summary>
    public static IUnit Quarts { get; } = new VolumeUnit("Quart", "qt", 0.946352946);

    /// <summary>
    /// Gets the US cup unit.
    /// </summary>
    public static IUnit Cups { get; } = new VolumeUnit("Cup", "cup", 0.2365882365);

    /// <summary>
    /// Gets the US fluid ounce unit.
    /// </summary>
    public static IUnit FluidOunces { get; } = new VolumeUnit("Fluid ounce", "fl oz", 0.0295735295625);

    private sealed class VolumeUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public VolumeUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
