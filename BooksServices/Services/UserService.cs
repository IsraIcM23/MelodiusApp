using BooksModels;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CreateUserAsync(UserDto user)
        {
            User _user = UserMapper.MapUserDtoToUser(user);
            return await _userRepository.CreateAsync(_user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return UserMapper.MapUsersToUserDtos(users);
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return UserMapper.MapUserToUserDto(user);
        }

        public async Task<bool> UpdateUserAsync(UserDto user)
        {
            User _user = UserMapper.MapUserDtoToUser(user);
            return  await _userRepository.UpdateAsync(_user);
        }

    }
}
