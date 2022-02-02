using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSearch.BLL.ModelsDTO;

namespace WebApiSearch.BLL.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<UsersDTO>> GetUsers(string searchValue);
    }
}
