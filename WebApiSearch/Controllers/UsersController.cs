using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSearch.BLL.Interfaces;
using WebApiSearch.BLL.ModelsDTO;

namespace WebApiSearch.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public async Task<IEnumerable<UsersDTO>> GetResultSearch([FromQuery] string searchValue)
        {
            var result = await usersService.GetUsers(searchValue);

            return result;
        }

    }
}
