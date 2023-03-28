using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface IPlayListService
    {
        Task<List<PlayListDto>> GetAllPlayListsAsync();
        Task<PlayListDto> GetPlayListByIdAsync(int id);
        Task<bool> CreatePlayListAsync(PlayListDto playList);
        Task<bool> UpdatePlayListAsync(PlayListDto playList);
        Task<bool> DeletePlayListAsync(int id);
    }
}
