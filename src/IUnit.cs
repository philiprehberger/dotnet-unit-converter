namespace Philiprehberger.UnitConverter;

/// <summary>
/// Defines a unit of measurement with conversion to and from a base unit.
/// </summary>
public interface IUnit
{
    /// <summary>
    /// Gets the full name of the unit.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the abbreviated symbol for the unit.
    /// </summary>
    string Symbol { get; }

    /// <summary>
    /// Converts a value in this unit to the base unit.
    /// </summary>
    /// <param name="value">The value in this unit.</param>
    /// <returns>The equivalent value in the base unit.</returns>
    double ToBase(double value);

    /// <summary>
    /// Converts a value from the base unit to this unit.
    /// </summary>
    /// <param name="value">The value in the base unit.</param>
    /// <returns>The equivalent value in this unit.</returns>
    double FromBase(double value);
}
