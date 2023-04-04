using BooksModels;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
        Task<int> CreateUserAsync(UserDto user);
        Task<UserDto> UpdateUserAsync(UserDto user);
        Task<int> DeleteUserAsync(int id);
        Task<UserCompleteResponse> GetUserByIdWithPlayListsAsync(int id);

    }
}
