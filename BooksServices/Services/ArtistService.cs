using MelodiusDataAccess.Repository.Implementation;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;

        public async Task<bool> CreateArtistAsync(ArtistDto artistDto)
        {
            var artist = ArtistMapper.MapArtistDtoToArtist(artistDto);
            return await _artistRepository.CreateAsync(artist);
        }

        public async Task<bool> DeleteArtistAsync(int id)
        {
            return await _artistRepository.DeleteAsync(id);
        }

        public async Task<List<ArtistDto>> GetAllArtistsAsync()
        {
            var artists = await _artistRepository.GetAllAsync();
            return ArtistMapper.MapArtistsToArtistDtos(artists);
        }

        public async Task<ArtistDto> GetArtistByIdAsync(int id)
        {
            var artist = await _artistRepository.GetByIdAsync(id);
            return ArtistMapper.MapArtistToArtistDto(artist);
        }

        public async Task<bool> UpdateArtistAsync(ArtistDto artistDto)
        {
            var artist = ArtistMapper.MapArtistDtoToArtist(artistDto);
            return await _artistRepository.UpdateAsync(artist);
        }
    }
}
