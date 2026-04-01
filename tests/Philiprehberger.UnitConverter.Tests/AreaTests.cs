using Philiprehberger.UnitConverter;
using Xunit;

namespace Philiprehberger.UnitConverter.Tests;

public class AreaTests
{
    private const double Tolerance = 0.001;

    [Fact]
    public void SquareMetersToSquareKilometers()
    {
        double result = Convert.From(1000000.0, Area.SquareMeters).To(Area.SquareKilometers);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void SquareMetersToSquareFeet()
    {
        double result = Convert.From(1.0, Area.SquareMeters).To(Area.SquareFeet);
        Assert.Equal(10.7639, result, Tolerance);
    }

    [Fact]
    public void SquareMetersToSquareYards()
    {
        double result = Convert.From(1.0, Area.SquareMeters).To(Area.SquareYards);
        Assert.Equal(1.19599, result, Tolerance);
    }

    [Fact]
    public void SquareMetersToAcres()
    {
        double result = Convert.From(4046.8564224, Area.SquareMeters).To(Area.Acres);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void SquareMetersToHectares()
    {
        double result = Convert.From(10000.0, Area.SquareMeters).To(Area.Hectares);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void AcresToHectares()
    {
        double result = Convert.From(2.471, Area.Acres).To(Area.Hectares);
        Assert.Equal(1.0, result, Tolerance);
    }

    [Fact]
    public void SquareKilometersToAcres()
    {
        double result = Convert.From(1.0, Area.SquareKilometers).To(Area.Acres);
        Assert.Equal(247.105, result, Tolerance);
    }

    [Fact]
    public void SquareFeetToSquareYards()
    {
        double result = Convert.From(9.0, Area.SquareFeet).To(Area.SquareYards);
        Assert.Equal(1.0, result, Tolerance);
    }
}
