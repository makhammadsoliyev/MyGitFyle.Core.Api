using System;
using GitFyle.Core.Api.Models.Foundations.Sources;

namespace GitFyle.Core.Api.Models.Foundations.Repositories;

public sealed class Repository
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Owner { get; set; }
    public string ExternalId { get; set; }
    public Guid SourceId { get; set; }
    public bool IsOrganization { get; set; }
    public bool IsPrivate { get; set; }
    public string Token { get; set; }
    public DateTimeOffset TokenExpireAt { get; set; }
    public DateTimeOffset CreateadAt { get; set; }
    public DateTimeOffset UpdateadAt { get;  set; }
    public Source Source { get; set; }
}
