using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Constants.Data;

/// <summary>
/// A set of commonly used constants related to various types of data
/// </summary>
[PublicOpenApiObject]
public static class DataConstants
{
    public const int Url = 2000;
    public const int Name = 255;
        
    /// <summary>
    /// Cosmos default is 100. -1 is commonly used to specify unlimited size of page.
    /// </summary>
    public const int DefaultCosmosPageSize = 500;
}