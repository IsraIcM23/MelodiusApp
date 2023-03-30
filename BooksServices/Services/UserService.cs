using BooksModels;
using MelodiusDataAccess.Repository.Implementation;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusDataTrasnfer.Responses;
using MelodiusModels;
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


        public async Task<int> CreateUserAsync(UserDto user)
        {
            User _user = UserMapper.MapUserDtoToUser(user);
            var newUser = await _userRepository.CreateAsync(_user);
            return newUser.Id;
        }


        public async Task<int> DeleteUserAsync(int id)
        {
            var deletedUser = await _userRepository.DeleteAsync(id);
            return deletedUser.Id;
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

        public async Task<UserDto> UpdateUserAsync(UserDto userDto)
        {
            var userModel = UserMapper.MapUserDtoToUser(userDto);
            var user = await _userRepository.UpdateAsync(userModel);
            return UserMapper.MapUserToUserDto(user);
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
