using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Services
{
    public class Convert
    {

        public Users ConvertDTOToEntity(UsersDTO userDTO)
        {
            var user = new Users();
            user.FirstName = userDTO.FirstName;
            user.LastName = userDTO.LastName;
            user.Email = userDTO.Email;
            user.BirthDay = userDTO.BirthDay;
            user.PhoneNumber = userDTO.PhoneNumber;
            user.UserName = userDTO.UserName;
            user.Password = userDTO.Password;
            user.IsDeleted = userDTO.IsDeleted;
            user.IsLocked = userDTO.IsLocked;
            user.IsMale = userDTO.IsMale;
            user.Skills = userDTO.Skills;
            user.Education = userDTO.Education;
            return user;
        }
    }
}
