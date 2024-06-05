namespace Domain.Entities;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Singer { get; set; }
    public Categories? Category { get; set; }
    public DateTime ReleaseDate { get; set; }
    public required List<Track> Tracks { get; set; }
}