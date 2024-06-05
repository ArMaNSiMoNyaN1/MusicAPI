namespace Domain.Entities;

public class Track
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Singer { get; set; }
    public Categories Category { get; set; }
}