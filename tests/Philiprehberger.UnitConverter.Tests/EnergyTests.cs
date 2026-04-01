using Philiprehberger.UnitConverter;
using Xunit;

namespace Philiprehberger.UnitConverter.Tests;

public class EnergyTests
{
    private const double Tolerance = 0.001;

    [Fact]
    public void JoulesToKilojoules()
    {
        double result = Convert.From(5000.0, Energy.Joules).To(Energy.Kilojoules);
        Assert.Equal(5.0, result, Tolerance);
    }

    [Fact]
    public void JoulesToCalories()
    {
        double result = Convert.From(4.184, Energy.Joules).To(Energy.Calories);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void JoulesToKilocalories()
    {
        double result = Convert.From(4184.0, Energy.Joules).To(Energy.Kilocalories);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void JoulesToWattHours()
    {
        double result = Convert.From(3600.0, Energy.Joules).To(Energy.WattHours);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void JoulesToKilowattHours()
    {
        double result = Convert.From(3600000.0, Energy.Joules).To(Energy.KilowattHours);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void JoulesToBTU()
    {
        double result = Convert.From(1055.06, Energy.Joules).To(Energy.BTU);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void KilocaloriesToKilojoules()
    {
        double result = Convert.From(1.0, Energy.Kilocalories).To(Energy.Kilojoules);
        Assert.Equal(4.184, result, Tolerance);
    }

    [Fact]
    public void KilowattHoursToBTU()
    {
        double result = Convert.From(1.0, Energy.KilowattHours).To(Energy.BTU);
        Assert.Equal(3412.14, result, 0.1);
    }

    [Fact]
    public void CaloriesToWattHours()
    {
        double result = Convert.From(860.421, Energy.Calories).To(Energy.WattHours);
        Assert.Equal(1.0, result, Tolerance);
    }
}
