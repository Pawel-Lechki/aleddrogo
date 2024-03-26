using Microsoft.EntityFrameworkCore;
using UsersAPI.Data;
using UsersAPI.Models;

namespace UsersAPI.Repositories;

public class SQLUserRepositories : IUserRepository
{
    private readonly AplicationDbContext _dbContext;

    public SQLUserRepositories(AplicationDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    public async Task<List<User>> GetAllAsync()
    {
        return await _dbContext.Users.Include("Address").ToListAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Users.Include("Address").FirstOrDefaultAsync(u => u.UserId == id);
    }

    public async Task<User> CreateAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return user;
    }

    public async Task<User?> UpdateAsync(Guid id, User user)
    {
        var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
        if (existingUser == null) return null;

        existingUser.Email = user.Email;
        existingUser.Password = user.Password;
        existingUser.FirstName = user.FirstName;
        existingUser.LastName = user.LastName;
        existingUser.Phone = user.Phone;
        existingUser.Address= new Address();
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User?> DeleteAsync(Guid id)
    {
        var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
        if (existingUser == null) return null;

        _dbContext.Users.Remove(existingUser);
        await _dbContext.SaveChangesAsync();

        return existingUser;
    }
}