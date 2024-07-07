using System;
using System.Collections.Generic;
using GitFyle.Core.Api.Models.Foundations.Repositories;

namespace GitFyle.Core.Api.Models.Foundations.Sources;

public sealed class Source
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public IEnumerable<Repository> Repositories { get; set; }
}
