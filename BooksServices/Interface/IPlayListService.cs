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
        Task<int> CreatePlayListAsync(PlayListDto playList);
        Task<PlayListDto> UpdatePlayListAsync(PlayListDto playList);
        Task<int> DeletePlayListAsync(int id);
    }
}
