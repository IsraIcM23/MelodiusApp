using BooksModels;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusDataTrasnfer.Responses;
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
        private readonly IPlayListRepository _layListRepository;

        public UserService(IUserRepository userRepository, IPlayListRepository playListRepository)
        {
            _userRepository = userRepository;
            _layListRepository = playListRepository;
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

        //public async Task<UserCompleteResponse> GetUserByIdWithPlayListsAsync(int id)
        //{
        //    var user = await _userRepository.GetByIdAsync(id);
        //    var playLists = await _layListRepository.GetAllAsync();

        //    foreach (var playList in playLists)
        //    {
        //        if (playList.User.Id == id)
        //        {
        //            user.playLists.Add(playList);
        //        }
        //    }

        //    UserCompleteResponse response = new UserCompleteResponse();
        //    response.Id = user.Id;
        //    response.Name = user.Name;
        //    response.Password = user.Password;
        //    response.Email = user.Email;
        //    response.playLists = user.playLists;

        //    return response;
        //}


    }
}
