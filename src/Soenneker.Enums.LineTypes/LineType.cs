using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.LineTypes;

/// <summary>
/// Classifies the access technology or service type associated with a telephone number.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class LineType
{
    /// <summary>
    /// Fixed physical wireline or landline service.
    /// </summary>
    public static readonly LineType Wireline = new(nameof(Wireline));
    /// <summary>
    /// Mobile wireless or cellular service.
    /// </summary>
    public static readonly LineType Wireless = new(nameof(Wireless));
    /// <summary>
    /// Voice-over-Wi-Fi service carried through a wireless internet connection.
    /// </summary>
    public static readonly LineType VoWiFi = new(nameof(VoWiFi));
    /// <summary>
    /// Voice over IP service carried through an internet protocol network.
    /// </summary>
    public static readonly LineType VoIP = new(nameof(VoIP));
    /// <summary>
    /// Prepaid mobile wireless service.
    /// </summary>
    public static readonly LineType PrePaidWireless = new(nameof(PrePaidWireless));
    /// <summary>
    /// Line type could not be determined from available data.
    /// </summary>
    public static readonly LineType Unknown = new(nameof(Unknown));
}
