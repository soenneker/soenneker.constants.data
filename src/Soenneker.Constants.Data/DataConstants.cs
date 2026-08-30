using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Constants.Data;

/// <summary>
/// Defines shared validation and paging limits used by public data contracts.
/// </summary>
[PublicOpenApiObject]
public static class DataConstants
{
    /// <summary>
    /// Maximum supported length, in characters, for a URL value.
    /// </summary>
    public const int Url = 2000;
    /// <summary>
    /// Maximum supported length, in characters, for a human-readable name.
    /// </summary>
    public const int Name = 255;
        
    /// <summary>
    /// Default number of records requested per page by Soenneker Cosmos repository APIs.
    /// </summary>
    public const int DefaultCosmosPageSize = 500;
}
