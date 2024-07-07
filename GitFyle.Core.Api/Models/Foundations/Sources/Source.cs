using System;

namespace GitFyle.Core.Api.Models.Foundations.Sources;

public sealed class Source
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}
