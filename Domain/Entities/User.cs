namespace Domain.Entities;

public class User
{    
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required string Username { get; set; }
    public required List<Track> FavoritesTrack { get; set; }
    public required List<Signer> FavoritesSigner { get; set; }
    public required List<Track> Tracks { get; set; }
}