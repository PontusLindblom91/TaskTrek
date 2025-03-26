using TaskTrek.Data.Repositories;
using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;

namespace TaskTrek.Services
{
    public class UserService
    {
        private readonly UserRepo _userRepo;

        public UserService(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task InsertUser(string userName)
        {
            var user = new User { UserName = userName };

            await _userRepo.InsertUser(user);
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            var users = await _userRepo.GetAllUsers();

            var userDTOs = new List<UserDTO>();

            foreach (var user in users) 
            {
                var userDto = new UserDTO
                { UserName = user.UserName };

                userDTOs.Add(userDto);
            }
            return userDTOs;
        }
    }
}
