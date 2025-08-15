using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.LineTypes;

/// <summary>
/// An enumerator describing phone line types
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public sealed partial class LineType
{
    public static readonly LineType Wireline = new(nameof(Wireline));
    public static readonly LineType Wireless = new(nameof(Wireless));
    public static readonly LineType VoWiFi = new(nameof(VoWiFi));
    public static readonly LineType VoIP = new(nameof(VoIP));
    public static readonly LineType PrePaidWireless = new(nameof(PrePaidWireless));
}