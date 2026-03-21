namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides units of digital data size. The base unit is bytes.
/// </summary>
public static class DataSize
{
    /// <summary>
    /// Gets the byte unit.
    /// </summary>
    public static IUnit Bytes { get; } = new DataSizeUnit("Byte", "B", 1.0);

    /// <summary>
    /// Gets the kilobyte unit (1,024 bytes).
    /// </summary>
    public static IUnit KB { get; } = new DataSizeUnit("Kilobyte", "KB", 1024.0);

    /// <summary>
    /// Gets the megabyte unit (1,048,576 bytes).
    /// </summary>
    public static IUnit MB { get; } = new DataSizeUnit("Megabyte", "MB", 1_048_576.0);

    /// <summary>
    /// Gets the gigabyte unit (1,073,741,824 bytes).
    /// </summary>
    public static IUnit GB { get; } = new DataSizeUnit("Gigabyte", "GB", 1_073_741_824.0);

    /// <summary>
    /// Gets the terabyte unit.
    /// </summary>
    public static IUnit TB { get; } = new DataSizeUnit("Terabyte", "TB", 1_099_511_627_776.0);

    /// <summary>
    /// Gets the petabyte unit.
    /// </summary>
    public static IUnit PB { get; } = new DataSizeUnit("Petabyte", "PB", 1_125_899_906_842_624.0);

    private sealed class DataSizeUnit : IUnit
    {
        private readonly double _factor;

        public string Name { get; }
        public string Symbol { get; }

        public DataSizeUnit(string name, string symbol, double factor)
        {
            Name = name;
            Symbol = symbol;
            _factor = factor;
        }

        public double ToBase(double value) => value * _factor;
        public double FromBase(double value) => value / _factor;
    }
}
