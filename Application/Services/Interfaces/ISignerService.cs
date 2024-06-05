using Domain.Entities;

namespace Application.Services.Interfaces;

public interface ISignerService
{
    Task<List<Signer>> GetAll();
    Task<Signer?> GetById(int id);
    Task<Signer> Add(Signer signer);
    Task<Signer?> Update(Signer updateSigner);
    Task<Signer> Delete(int id);
}