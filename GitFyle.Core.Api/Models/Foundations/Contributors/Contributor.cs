using System;
using GitFyle.Core.Api.Models.Foundations.Sources;

namespace GitFyle.Core.Api.Models.Foundations.Contributors;

public sealed class Contributor
{
    public Guid Id { get; set; }
    public string ExternalId { get; set; }
    public Guid SourceId { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string AvatarUrl { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public Source Source { get; set; }
}
