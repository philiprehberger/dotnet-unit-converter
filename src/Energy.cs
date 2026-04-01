namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of energy measurement. The base unit is joules.
/// </summary>
public static class Energy
{
    /// <summary>
    /// Gets the joule unit.
    /// </summary>
    public static IUnit Joules { get; } = new EnergyUnit("Joule", "J", 1.0);

    /// <summary>
    /// Gets the kilojoule unit.
    /// </summary>
    public static IUnit Kilojoules { get; } = new EnergyUnit("Kilojoule", "kJ", 1000.0);

    /// <summary>
    /// Gets the calorie unit.
    /// </summary>
    public static IUnit Calories { get; } = new EnergyUnit("Calorie", "cal", 4.184);

    /// <summary>
    /// Gets the kilocalorie unit.
    /// </summary>
    public static IUnit Kilocalories { get; } = new EnergyUnit("Kilocalorie", "kcal", 4184.0);

    /// <summary>
    /// Gets the watt-hour unit.
    /// </summary>
    public static IUnit WattHours { get; } = new EnergyUnit("Watt-Hour", "Wh", 3600.0);

    /// <summary>
    /// Gets the kilowatt-hour unit.
    /// </summary>
    public static IUnit KilowattHours { get; } = new EnergyUnit("Kilowatt-Hour", "kWh", 3600000.0);

    /// <summary>
    /// Gets the British thermal unit.
    /// </summary>
    public static IUnit BTU { get; } = new EnergyUnit("BTU", "BTU", 1055.06);

    private sealed class EnergyUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public EnergyUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
