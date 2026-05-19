using System;

namespace LiveMatchApi.Core.Models;

public class Area
{
	public DateTime Timestamp { get; set; }
	public int Id { get; set; }
	public required string ExternalId { get; set; }
	public string? Name { get; set; }
	public string? Code { get; set; }
	public string? Flag { get; set; }
	public int AreaId { get; set; }
	public DateTime LastUpdated { get; set; }
}
