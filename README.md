[![](https://img.shields.io/nuget/v/Soenneker.Constants.Data.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Constants.Data/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.data/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.constants.data/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Constants.Data.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Constants.Data/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.data/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.constants.data/actions/workflows/codeql.yml)

# Soenneker.Constants.Data

Defines shared validation and paging limits used by public data contracts.

## Install

```bash
dotnet add package Soenneker.Constants.Data
```

## What you get

- `DataConstants` — Defines shared validation and paging limits used by public data contracts.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DataConstants.Url` | Maximum supported length, in characters, for a URL value. | Maximum supported length, in characters, for a URL value. |
| `DataConstants.Name` | Maximum supported length, in characters, for a human-readable name. | Maximum supported length, in characters, for a human-readable name. |
| `DataConstants.DefaultCosmosPageSize` | Default number of records requested per page from Cosmos DB. A page size of `-1` is commonly used to request an unlimited page. | Default number of records requested per page from Cosmos DB. A page size of `-1` is commonly used to request an unlimited page. |
