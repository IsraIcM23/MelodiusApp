using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Request;
using MelodiusDataTrasnfer.Responses;
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
        Task<int> CreateSongAsync(SongDto song);
        Task<SongDto> UpdateSongAsync(SongDto song);
        Task<int> DeleteSongAsync(int id);

        public Task<CompleteSongResponse> AddCompleteSong(CompleteSongRequest song);
    }
}
