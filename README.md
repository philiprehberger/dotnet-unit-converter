# Philiprehberger.UnitConverter

[![NuGet](https://img.shields.io/nuget/v/Philiprehberger.UnitConverter)](https://www.nuget.org/packages/Philiprehberger.UnitConverter)
[![CI](https://github.com/philiprehberger/dotnet-unit-converter/actions/workflows/ci.yml/badge.svg)](https://github.com/philiprehberger/dotnet-unit-converter/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/philiprehberger/dotnet-unit-converter/blob/main/LICENSE)

Type-safe unit conversions between length, weight, temperature, volume, data size, and speed with formatting.

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

## Development

```bash
dotnet build src/Philiprehberger.UnitConverter.csproj --configuration Release
```

## License

MIT
