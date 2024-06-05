using Domain.Entities;

namespace Application.Services.Interfaces;

public interface ITrackService
{
    Task<List<Track>> GetAll();
    Task<Track?> GetById(int id);
    Task<Track> Add(Track track);
    Task<Track?> Update(Track updateTrack);
    Task<bool> Delete(int id);
}