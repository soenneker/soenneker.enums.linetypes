[![](https://img.shields.io/nuget/v/soenneker.enums.linetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.linetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.linetypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.linetypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.linetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.linetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.linetypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.linetypes/actions/workflows/codeql.yml)

# Soenneker.Enums.LineTypes

Classifies the access technology or service type associated with a telephone number.

## Install

```bash
dotnet add package Soenneker.Enums.LineTypes
```

## What you get

- `LineType` — Classifies the access technology or service type associated with a telephone number.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `LineType.Wireline` | Fixed physical wireline or landline service. | Fixed physical wireline or landline service. |
| `LineType.Wireless` | Mobile wireless or cellular service. | Mobile wireless or cellular service. |
| `LineType.VoWiFi` | Voice-over-Wi-Fi service carried through a wireless internet connection. | Voice-over-Wi-Fi service carried through a wireless internet connection. |
| `LineType.VoIP` | Voice over IP service carried through an internet protocol network. | Voice over IP service carried through an internet protocol network. |
| `LineType.Unknown` | Line type could not be determined from available data. | Line type could not be determined from available data. |
