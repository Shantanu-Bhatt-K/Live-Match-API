using System;

namespace LiveMatchApi.Core.Models;

public class Match
{
    public DateTime Timestamp { get; set; }
    public int Id { get; set; }
    public int ExternalId { get; set; }
    public int CompetitionId { get; set; }
    public int? MatchDay { get; set; }
    public string Stage {  get; set; } = string.Empty;
    public int? Season { get; set; }
    public string Venue { get; set; } = string.Empty;
    public int? Minute { get; set; }
    public int? Attendance { get; set; }
    public int HomeTeamId { get; set; }
    public int AwayTeamId { get; set; }
    public DateTime UtcDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
    public DateTime LastUpdated { get; set; }

}