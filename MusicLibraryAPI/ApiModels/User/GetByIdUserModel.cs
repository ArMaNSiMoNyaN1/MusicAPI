namespace MusicLibraryAPI.ApiModels.User;

public class GetByIdUserModel
{
    public required string Name { get; set; } = string.Empty;
    public required string Username { get; set; } = string.Empty;
}