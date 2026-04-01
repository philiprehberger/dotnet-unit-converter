using Philiprehberger.UnitConverter;
using Xunit;

namespace Philiprehberger.UnitConverter.Tests;

public class PressureTests
{
    private const double Tolerance = 0.001;

    [Fact]
    public void PascalsToKilopascals()
    {
        double result = Convert.From(5000.0, Pressure.Pascals).To(Pressure.Kilopascals);
        Assert.Equal(5.0, result, Tolerance);
    }

    [Fact]
    public void PascalsToBar()
    {
        double result = Convert.From(100000.0, Pressure.Pascals).To(Pressure.Bar);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void PascalsToPSI()
    {
        double result = Convert.From(6894.757293168, Pressure.Pascals).To(Pressure.PSI);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void PascalsToAtmosphere()
    {
        double result = Convert.From(101325.0, Pressure.Pascals).To(Pressure.Atmosphere);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void PascalsToTorr()
    {
        double result = Convert.From(133.32236842105, Pressure.Pascals).To(Pressure.Torr);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void PascalsToMillimetersOfMercury()
    {
        double result = Convert.From(133.322387415, Pressure.Pascals).To(Pressure.MillimetersOfMercury);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void PSIToAtmospheres()
    {
        double result = Convert.From(14.696, Pressure.PSI).To(Pressure.Atmosphere);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void BarToKilopascals()
    {
        double result = Convert.From(1.0, Pressure.Bar).To(Pressure.Kilopascals);
        Assert.Equal(100.0, result, Tolerance);
    }

    [Fact]
    public void AtmosphereToTorr()
    {
        double result = Convert.From(1.0, Pressure.Atmosphere).To(Pressure.Torr);
        Assert.Equal(760.0, result, Tolerance);
    }
}
