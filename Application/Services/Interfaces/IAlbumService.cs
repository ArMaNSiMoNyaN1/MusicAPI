using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IAlbumService
{
    Task<List<Album>> GetAll();
    Task<Album?> GetById(int id);
    Task<Album> Add(Album album);
    Task<Album?> Update(Album updateAlbum);
    Task<Album> Delete(int id);
}