using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSearch.Domain.Models;

namespace WebApiSearch.DAL.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetUsers(string searchValue);
    }
}
