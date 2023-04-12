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
        Task<int> CreateArtistAsync(ArtistDto artist);
        Task<ArtistDto> UpdateArtistAsync(ArtistDto artist);
        Task<int> DeleteArtistAsync(int id);
    }
}
