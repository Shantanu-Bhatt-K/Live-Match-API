using System;

namespace LiveMatchApi.Core.Models;
public class Competition
{
    public DateTime Timestamp { get; set; }
    public int Id { get; set; }
    public int ExternalId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code {  get; set; } = string.Empty;
    public int AreaId { get; set; }
    public string Emblem { get; set; } = string.Empty;
    public string Type {  get; set; } = string.Empty;
    public int? CurrentMatchDay { get; set; }
    public DateTime LastUpdated { get; set; }
}
