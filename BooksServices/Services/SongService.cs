using BooksModels;
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
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public async Task<bool> CreateSongAsync(SongDto song)
        {
            Song _song = SongMapper.MapSongDtoToSong(song);
            return await _songRepository.CreateAsync(_song);
        }

        public async Task<bool> DeleteSongAsync(int id)
        {
            return await _songRepository.DeleteAsync(id);
        }

        public async Task<List<SongDto>> GetAllSongsAsync()
        {
            var songs = await _songRepository.GetAllAsync();
            return SongMapper.MapSongsToSongsDtos(songs);
        }

        public async Task<SongDto> GetSongByIdAsync(int id)
        {
            var song = await _songRepository.GetByIdAsync(id);
            return SongMapper.MapSongToSongDto(song);
        }

        public async Task<bool> UpdateSongAsync(SongDto song)
        {
            Song _song = SongMapper.MapSongDtoToSong(song);
            return await _songRepository.UpdateAsync(_song);
        }
    }
}
