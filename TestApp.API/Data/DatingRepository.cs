using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.API.Models;

namespace TestApp.API.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _context;
        public DatingRepository(DataContext context)
        {
            _context = context;

        }

        public void add<T>(T entity) where T : class
        {
            _context.Add(entity); 
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include( p => p.Photos).FirstOrDefaultAsync( u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include( p => p.Photos).ToListAsync();
            return users;
        }

        public void remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0; // return true of false. är det mer än 0 vill vi spara något i db
        }
    }
}