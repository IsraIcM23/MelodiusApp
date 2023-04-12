using MelodiusDataAccess.Repository.Implementation;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusModels;
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

        public ArtistService (IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<int> CreateArtistAsync(ArtistDto artistDto)
        {
            Artist _artist = ArtistMapper.MapArtistDtoToArtist(artistDto);
            var newArtist = await _artistRepository.CreateAsync(_artist);
            return newArtist.Id;
        }

     

        public async Task<int> DeleteArtistAsync(int id)
        {
            var deletedArtist = await _artistRepository.DeleteAsync(id);
            return deletedArtist.Id;
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

        public async Task<ArtistDto> UpdateArtistAsync(ArtistDto artistDto)
        {
            Artist updatedArtist = ArtistMapper.MapArtistDtoToArtist(artistDto);
            var artist = await _artistRepository.UpdateAsync(updatedArtist);
            return ArtistMapper.MapArtistToArtistDto(artist);
        }

        


    }
}
