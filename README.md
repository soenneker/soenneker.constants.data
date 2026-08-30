[![](https://img.shields.io/nuget/v/Soenneker.Constants.Data.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Constants.Data/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.data/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.constants.data/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Constants.Data.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Constants.Data/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.data/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.constants.data/actions/workflows/codeql.yml)

# Soenneker.Constants.Data

Provides shared string-length limits and the default Cosmos DB page size used across Soenneker data contracts.

## Install

```bash
dotnet add package Soenneker.Constants.Data
```

## Values

| Constant | Value | Intended use |
| --- | ---: | --- |
| `DataConstants.Url` | `2000` | Maximum character count for URL fields |
| `DataConstants.Name` | `255` | Maximum character count for human-readable names |
| `DataConstants.DefaultCosmosPageSize` | `500` | Default item count requested by Soenneker Cosmos paging APIs |

## Usage

```csharp
using System.ComponentModel.DataAnnotations;
using Soenneker.Constants.Data;

public sealed class CreateLinkRequest
{
    [StringLength(DataConstants.Name)]
    public required string Name { get; init; }

    [StringLength(DataConstants.Url)]
    public required string Url { get; init; }
}
```

These are compile-time constants, so their numeric values are embedded into consuming assemblies. Rebuild consumers after upgrading if a constant changes.

`DefaultCosmosPageSize` is a library convention, not a Cosmos DB service limit. Override it when request-unit cost, response size, or latency requires a different page size.
