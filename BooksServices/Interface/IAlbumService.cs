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
        Task<int> CreateAlbumAsync(AlbumDto album);
        Task<AlbumDto> UpdateAlbumAsync(AlbumDto album);
        Task<int> DeleteAlbumAsync(int id);
    }
}
