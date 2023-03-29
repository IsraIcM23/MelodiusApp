using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface IArtistService
    {
        Task<List<ArtistDto>> GetAllArtistsAsync();
        Task<ArtistDto> GetArtistByIdAsync(int id);
        Task<bool> CreateArtistAsync(ArtistDto artist);
        Task<bool> UpdateArtistAsync(ArtistDto artist);
        Task<bool> DeleteArtistAsync(int id);
    }
}
