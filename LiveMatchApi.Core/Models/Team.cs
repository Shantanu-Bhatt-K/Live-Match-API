using System;

namespace LiveMatchApi.Core.Models;


public class Team
{
    public int Id { get; set; }
    public int ExternalId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Tla {  get; set; } = string.Empty;
    public string Crest {  get; set; } = string.Empty;
    public int? Founded { get; set; }
    public string Venue {  get; set; } = string.Empty;
    public int AreaId { get; set; }
}
