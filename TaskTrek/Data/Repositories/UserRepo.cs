﻿using Microsoft.EntityFrameworkCore;
using TaskTrek.Data.Context;
using TaskTrek.Models.Entities;

namespace TaskTrek.Data.Repositories
{
    public class UserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public async Task<int> GetUserByUserName(string userName)
        {
            var user = await _context.Users
        .Where(u => u.UserName == userName)
        .Select(u => u.UserID)
        .FirstAsync();

            return user;
        }

        public async Task<string> GetUserById(int userId)
        {
            var user = await _context.Users
        .Where(u => u.UserID == userId)
        .Select(u => u.UserName)
        .FirstOrDefaultAsync();

            return user;
        }
    }
}

