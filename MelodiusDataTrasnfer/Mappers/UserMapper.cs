using BooksModels;
using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Mappers
{
    public static class UserMapper
    {
        public static UserDto MapUserToUserDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }

        public static User MapUserDtoToUser(UserDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Name = userDto.Name,
                Email = userDto.Email,
                Password = userDto.Password
            };
        }

        public static List<UserDto> MapUsersToUserDtos(List<User> users)
        {
            return users.Select(user => MapUserToUserDto(user)).ToList();
        }

        public static List<User> MapUserDtosToUsers(List<UserDto> userDtos)
        {
            return userDtos.Select(userDto => MapUserDtoToUser(userDto)).ToList();
        }
    }
}
