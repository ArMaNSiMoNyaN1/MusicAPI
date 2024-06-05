namespace MusicLibraryAPI.ApiModels.User;

public class UpdateUserModel
{
    public int Id { get; set; }
    
    public required string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;
}