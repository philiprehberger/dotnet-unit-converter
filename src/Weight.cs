namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of weight measurement. The base unit is kilograms.
/// </summary>
public static class Weight
{
    /// <summary>
    /// Gets the kilogram unit.
    /// </summary>
    public static IUnit Kilograms { get; } = new WeightUnit("Kilogram", "kg", 1.0);

    /// <summary>
    /// Gets the gram unit.
    /// </summary>
    public static IUnit Grams { get; } = new WeightUnit("Gram", "g", 0.001);

    /// <summary>
    /// Gets the milligram unit.
    /// </summary>
    public static IUnit Milligrams { get; } = new WeightUnit("Milligram", "mg", 0.000001);

    /// <summary>
    /// Gets the pound unit.
    /// </summary>
    public static IUnit Pounds { get; } = new WeightUnit("Pound", "lb", 0.45359237);

    /// <summary>
    /// Gets the ounce unit.
    /// </summary>
    public static IUnit Ounces { get; } = new WeightUnit("Ounce", "oz", 0.028349523125);

    /// <summary>
    /// Gets the metric ton unit.
    /// </summary>
    public static IUnit Tons { get; } = new WeightUnit("Ton", "t", 1000.0);

    private sealed class WeightUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public WeightUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
