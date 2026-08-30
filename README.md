[![](https://img.shields.io/nuget/v/soenneker.enums.linetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.linetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.linetypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.linetypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.linetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.linetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.linetypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.linetypes/actions/workflows/codeql.yml)

# Soenneker.Enums.LineTypes

A string-backed enum-value type for carrying a telephone line classification returned by a lookup or communications provider.

## Install

```bash
dotnet add package Soenneker.Enums.LineTypes
```

## Usage

```csharp
using Soenneker.Enums.LineTypes;

LineType lineType = LineType.Wireless;
string wireValue = lineType.Value; // "Wireless"

if (LineType.TryFromValue(providerValue, out LineType? parsed))
{
    // parsed is one of the shared static instances
}
```

Available values:

- `Wireline` — fixed landline service
- `Wireless` — mobile or cellular service
- `VoWiFi` — voice over Wi-Fi
- `VoIP` — voice over IP
- `PrePaidWireless` — prepaid mobile service
- `Unknown` — the source could not determine a type

`System.Text.Json` serializes the type as the shown string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` when parsing provider data. `FromName` and `TryFromName` are also generated.

This package represents a supplied classification; it does not inspect or validate phone numbers, query carrier data, or establish whether a number is reachable. Provider categories can differ and classifications can become stale after number porting, so retain `Unknown` and avoid treating a line type as a security or identity signal.
