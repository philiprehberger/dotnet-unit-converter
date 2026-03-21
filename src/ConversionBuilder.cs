namespace Philiprehberger.UnitConverter;

/// <summary>
/// Provides a fluent interface for converting a value from one unit to another.
/// </summary>
public class ConversionBuilder
{
    private readonly double _value;
    private readonly IUnit _sourceUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="sourceUnit">The source unit of the value.</param>
    internal ConversionBuilder(double value, IUnit sourceUnit)
    {
        _value = value;
        _sourceUnit = sourceUnit;
    }

    /// <summary>
    /// Converts the stored value to the specified target unit.
    /// </summary>
    /// <param name="target">The unit to convert to.</param>
    /// <returns>The converted value in the target unit.</returns>
    public double To(IUnit target)
    {
        var baseValue = _sourceUnit.ToBase(_value);
        return target.FromBase(baseValue);
    }
}
