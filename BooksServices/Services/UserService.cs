using BooksModels;
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

        public async Task<UserCompleteResponse> GetUserByIdWithPlayListsAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            var playLists = await _layListRepository.GetAllAsync();

            var userDto = UserMapper.MapUserToUserDto(user);
            var playListDtos = PlayListMapper.MapPlayListsToPlayListDtos(playLists);

            
            List< PlayListDto > lists = new List< PlayListDto >();

            foreach (var playList in playListDtos)
            {
                if (playList.UserId == id)
                {
                    lists.Add(playList);
                }
            }

            UserCompleteResponse response = new UserCompleteResponse();
            response.Id = userDto.Id;
            response.Name = userDto.Name;
            response.Password = userDto.Password;
            response.Email = userDto.Email;
            response.playLists = lists;

            return response;
        }


    }
}
