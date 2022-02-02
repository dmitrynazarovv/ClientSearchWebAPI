using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSearch.DAL.Interfaces;
using WebApiSearch.Domain.Models;

namespace WebApiSearch.DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationContext db;
        public UsersRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Users>> GetUsers(string searchValue)
        {
            var result = await db.Users.Where(x => x.Fio.Contains(searchValue)).ToListAsync();

            return result;
        } 
    }
}
