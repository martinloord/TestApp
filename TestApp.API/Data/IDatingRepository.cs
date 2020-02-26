using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.API.Models;

namespace TestApp.API.Data
{
    public interface IDatingRepository
    {
         void add<T>(T entity) where T: class; // (generic) Add a type of T, entity som parameter, where T is a type of class.
         void remove<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers(); // lista av användare 
         Task<User> GetUser(int id); // ta ut en användare - med id?
    }
}