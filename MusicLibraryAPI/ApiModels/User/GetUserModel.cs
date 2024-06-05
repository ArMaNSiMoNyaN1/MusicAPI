using Domain.Entities;

namespace MusicLibraryAPI.ApiModels.User;

public class GetUserModel
{
    public int Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public string SurName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public required List<Track> Tracks { get; set; }
    public required List<Track> FavoritesTrack { get; set; }
    public required List<Signer> FavoritesSigner { get; set; } 

}