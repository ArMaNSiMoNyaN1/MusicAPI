using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> GetAll();
    Task<User?> GetById(int id);
    Task<User> Add(User user);
    Task<User?> Update(User updateUser);
    Task<bool> Delete(int id);
}