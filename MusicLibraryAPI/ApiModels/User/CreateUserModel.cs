namespace MusicLibraryAPI.ApiModels.User;

public class CreateUserModel
{
    public required string Name { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
}
