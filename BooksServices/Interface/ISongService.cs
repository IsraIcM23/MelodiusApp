using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface ISongService
    {
        Task<List<SongDto>> GetAllSongsAsync();
        Task<SongDto> GetSongByIdAsync(int id);
        Task<bool> CreateSongAsync(SongDto song);
        Task<bool> UpdateSongAsync(SongDto song);
        Task<bool> DeleteSongAsync(int id);
    }
}
