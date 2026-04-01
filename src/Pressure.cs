namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of pressure measurement. The base unit is pascals.
/// </summary>
public static class Pressure
{
    /// <summary>
    /// Gets the pascal unit.
    /// </summary>
    public static IUnit Pascals { get; } = new PressureUnit("Pascal", "Pa", 1.0);

    /// <summary>
    /// Gets the kilopascal unit.
    /// </summary>
    public static IUnit Kilopascals { get; } = new PressureUnit("Kilopascal", "kPa", 1000.0);

    /// <summary>
    /// Gets the bar unit.
    /// </summary>
    public static IUnit Bar { get; } = new PressureUnit("Bar", "bar", 100000.0);

    /// <summary>
    /// Gets the PSI unit.
    /// </summary>
    public static IUnit PSI { get; } = new PressureUnit("PSI", "psi", 6894.757293168);

    /// <summary>
    /// Gets the atmosphere unit.
    /// </summary>
    public static IUnit Atmosphere { get; } = new PressureUnit("Atmosphere", "atm", 101325.0);

    /// <summary>
    /// Gets the torr unit.
    /// </summary>
    public static IUnit Torr { get; } = new PressureUnit("Torr", "Torr", 133.32236842105);

    /// <summary>
    /// Gets the millimeters of mercury unit.
    /// </summary>
    public static IUnit MillimetersOfMercury { get; } = new PressureUnit("Millimeters of Mercury", "mmHg", 133.322387415);

    private sealed class PressureUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public PressureUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
