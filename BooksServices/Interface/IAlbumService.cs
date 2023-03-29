using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface IAlbumService
    {
        Task<List<AlbumDto>> GetAllAlbumsAsync();
        Task<AlbumDto> GetAlbumByIdAsync(int id);
        Task<bool> CreateAlbumAsync(AlbumDto album);
        Task<bool> UpdateAlbumAsync(AlbumDto album);
        Task<bool> DeleteAlbumAsync(int id);
    }
}
