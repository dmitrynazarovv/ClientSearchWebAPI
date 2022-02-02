using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSearch.BLL.Helpers;
using WebApiSearch.BLL.Interfaces;
using WebApiSearch.BLL.ModelsDTO;
using WebApiSearch.DAL.Interfaces;

namespace WebApiSearch.BLL.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<IEnumerable<UsersDTO>> GetUsers(string searchValue)
        {
            var users = await usersRepository.GetUsers(searchValue);
            var result = users.Select(x => UsersConverter.GetConvertUsersDTO(x)).ToList();

            return result;
        }
    }
}
