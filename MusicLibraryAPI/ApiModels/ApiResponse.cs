using System.Net;

namespace MusicLibraryAPI.ApiModels;

public class ApiResponse
{
    public ApiResponse()
    {
        ErrorMessage = new List<string>();
    }

    public HttpStatusCode StatusCode { get; set; }
    public bool IsSuccess { get; set; } = true;
    public object Result { get; set; }
    public List<string> ErrorMessage { get; set; }
}