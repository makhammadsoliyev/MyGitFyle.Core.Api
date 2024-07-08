using System;

namespace GitFyle.Core.Api.Models.Foundations.ContributionTypes;

public sealed class ContributionType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
}
