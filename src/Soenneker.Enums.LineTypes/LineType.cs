using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.LineTypes;

/// <summary>
/// An enumerator describing phone line types
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class LineType
{
    /// <summary>
    /// The wireline.
    /// </summary>
    public static readonly LineType Wireline = new(nameof(Wireline));
    /// <summary>
    /// The wireless.
    /// </summary>
    public static readonly LineType Wireless = new(nameof(Wireless));
    /// <summary>
    /// The vo wi fi.
    /// </summary>
    public static readonly LineType VoWiFi = new(nameof(VoWiFi));
    /// <summary>
    /// The vo ip.
    /// </summary>
    public static readonly LineType VoIP = new(nameof(VoIP));
    /// <summary>
    /// The pre paid wireless.
    /// </summary>
    public static readonly LineType PrePaidWireless = new(nameof(PrePaidWireless));
    /// <summary>
    /// The unknown.
    /// </summary>
    public static readonly LineType Unknown = new(nameof(Unknown));
}