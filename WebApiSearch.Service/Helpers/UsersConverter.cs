using WebApiSearch.BLL.ModelsDTO;
using WebApiSearch.Domain.Models;

namespace WebApiSearch.BLL.Helpers
{
    public class UsersConverter
    {
        public static UsersDTO GetConvertUsersDTO(Users user)
        {
            var result = new UsersDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Patronymic = user.Patronymic
            };

            return result;
        }
    }
}
