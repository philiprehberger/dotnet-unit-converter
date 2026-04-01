# Philiprehberger.UnitConverter

[![CI](https://github.com/philiprehberger/dotnet-unit-converter/actions/workflows/ci.yml/badge.svg)](https://github.com/philiprehberger/dotnet-unit-converter/actions/workflows/ci.yml)
[![NuGet](https://img.shields.io/nuget/v/Philiprehberger.UnitConverter.svg)](https://www.nuget.org/packages/Philiprehberger.UnitConverter)
[![Last updated](https://img.shields.io/github/last-commit/philiprehberger/dotnet-unit-converter)](https://github.com/philiprehberger/dotnet-unit-converter/commits/main)

Type-safe unit conversions for length, weight, temperature, volume, data size, speed, pressure, area, and energy.

## Installation

```bash
dotnet add package Philiprehberger.UnitConverter
```

## Usage

### Length Conversion

```csharp
using Philiprehberger.UnitConverter;

double miles = Convert.From(5.0, Length.Kilometers).To(Length.Miles);
// 3.106855...
```

### Temperature Conversion

```csharp
using Philiprehberger.UnitConverter;

double fahrenheit = Convert.From(100.0, Temperature.Celsius).To(Temperature.Fahrenheit);
// 212.0

double kelvin = Convert.From(0.0, Temperature.Celsius).To(Temperature.Kelvin);
// 273.15
```

### Data Size Formatting

```csharp
using Philiprehberger.UnitConverter;

string result = Convert.Format(2_500_000.0, DataSize.Bytes, DataSize.MB, "F2");
// "2.38 MB"
```

### Pressure Conversion

```csharp
using Philiprehberger.UnitConverter;

double bar = Convert.From(101325.0, Pressure.Pascals).To(Pressure.Bar);
// 1.01325

double psi = Convert.From(1.0, Pressure.Atmosphere).To(Pressure.PSI);
// 14.696...
```

### Area Conversion

```csharp
using Philiprehberger.UnitConverter;

double acres = Convert.From(1.0, Area.SquareKilometers).To(Area.Acres);
// 247.105...

double hectares = Convert.From(10000.0, Area.SquareMeters).To(Area.Hectares);
// 1.0
```

### Energy Conversion

```csharp
using Philiprehberger.UnitConverter;

double calories = Convert.From(4.184, Energy.Joules).To(Energy.Calories);
// 1.0

double kwh = Convert.From(3600000.0, Energy.Joules).To(Energy.KilowattHours);
// 1.0
```

## API

| Member | Description |
| --- | --- |
| `Convert.From(double value, IUnit unit)` | Starts a conversion from the given value and unit, returns a `ConversionBuilder`. |
| `Convert.Format(double value, IUnit from, IUnit to, string? format)` | Converts and returns a formatted string with the target unit symbol. |
| `ConversionBuilder.To(IUnit target)` | Completes the conversion and returns the result as a `double`. |
| `IUnit` | Interface representing a unit with `Name`, `Symbol`, `ToBase`, and `FromBase`. |
| `Length` | Meters, Kilometers, Centimeters, Millimeters, Inches, Feet, Yards, Miles. |
| `Weight` | Kilograms, Grams, Milligrams, Pounds, Ounces, Tons. |
| `Temperature` | Celsius, Fahrenheit, Kelvin. |
| `Volume` | Liters, Milliliters, Gallons, Quarts, Cups, FluidOunces. |
| `DataSize` | Bytes, KB, MB, GB, TB, PB. |
| `Speed` | MetersPerSecond, KilometersPerHour, MilesPerHour, Knots. |
| `Pressure` | Pascals, Kilopascals, Bar, PSI, Atmosphere, Torr, MillimetersOfMercury. |
| `Area` | SquareMeters, SquareKilometers, SquareFeet, SquareYards, Acres, Hectares. |
| `Energy` | Joules, Kilojoules, Calories, Kilocalories, WattHours, KilowattHours, BTU. |

## Development

```bash
dotnet build src/Philiprehberger.UnitConverter.csproj --configuration Release
```

## Support

If you find this project useful:

⭐ [Star the repo](https://github.com/philiprehberger/dotnet-unit-converter)

🐛 [Report issues](https://github.com/philiprehberger/dotnet-unit-converter/issues?q=is%3Aissue+is%3Aopen+label%3Abug)

💡 [Suggest features](https://github.com/philiprehberger/dotnet-unit-converter/issues?q=is%3Aissue+is%3Aopen+label%3Aenhancement)

❤️ [Sponsor development](https://github.com/sponsors/philiprehberger)

🌐 [All Open Source Projects](https://philiprehberger.com/open-source-packages)

💻 [GitHub Profile](https://github.com/philiprehberger)

🔗 [LinkedIn Profile](https://www.linkedin.com/in/philiprehberger)

## License

[MIT](LICENSE)
