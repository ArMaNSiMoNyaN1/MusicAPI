using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations;

public class UserService : IUserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAll()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    public async Task<User?> GetById(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User> Add(User user)
    {
        var result = _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return (await GetById(result.Entity.Id))!;
    }

    public async Task<User?> Update(User updateUser)
    {
        var user = await _context.Users.FindAsync(updateUser.Id);
        if (user is null) return null;

        user.Id = updateUser.Id;
        user.Name = updateUser.Name;
        user.Surname = updateUser.Surname;
        user.Username = updateUser.Username;
        user.FavoritesTrack = updateUser.FavoritesTrack;
        user.FavoritesSigner = updateUser.FavoritesSigner;
        user.Tracks = updateUser.Tracks;

        return user;
    }

    public async Task<bool> Delete(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user is null) return false;

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }
}