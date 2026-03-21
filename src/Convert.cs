namespace Philiprehberger.UnitConverter;

/// <summary>
/// Entry point for unit conversions. Provides a fluent API for converting between units.
/// </summary>
public static class Convert
{
    /// <summary>
    /// Begins a unit conversion from the specified value and unit.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The source unit of the value.</param>
    /// <returns>A <see cref="ConversionBuilder"/> for specifying the target unit.</returns>
    public static ConversionBuilder From(double value, IUnit unit)
    {
        return new ConversionBuilder(value, unit);
    }

    /// <summary>
    /// Converts a value between units and returns a formatted string.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit.</param>
    /// <param name="to">The target unit.</param>
    /// <param name="format">An optional numeric format string (e.g., "F2").</param>
    /// <returns>A formatted string with the converted value and target unit symbol.</returns>
    public static string Format(double value, IUnit from, IUnit to, string? format = null)
    {
        var result = From(value, from).To(to);
        var formatted = format is not null ? result.ToString(format) : result.ToString();
        return $"{formatted} {to.Symbol}";
    }
}
