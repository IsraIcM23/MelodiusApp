using BooksModels;
using MelodiusDataAccess.Repository.Implementation;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
using MelodiusDataTrasnfer.Request;
using MelodiusDataTrasnfer.Responses;
using MelodiusModels;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


namespace MelodiusServices.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IAlbumSongRepository _albumSongRepository;


        public SongService(ISongRepository songRepository, IAlbumRepository albumRepository)
        {
            _songRepository = songRepository;
            _albumRepository = albumRepository;
        }

        public async Task<int> CreateSongAsync(SongDto song)
        {
            Song _song = SongMapper.MapSongDtoToSong(song);
            var newSong = await _songRepository.CreateAsync(_song);
            return newSong.Id;
        }

        public async Task<int> DeleteSongAsync(int id)
        {
            var deletedSong = await _songRepository.DeleteAsync(id);
            return deletedSong.Id;
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

        public async Task<SongDto> UpdateSongAsync(SongDto songDto)
        {
            var songModel = SongMapper.MapSongDtoToSong(songDto);
            var song = await _songRepository.UpdateAsync(songModel);
            return SongMapper.MapSongToSongDto(song);
        }

        public async Task<CompleteSongResponse> AddCompleteSong(CompleteSongRequest completeSong)
        {
            SongDto songDto = completeSong.Song;
            Song song = SongMapper.MapSongDtoToSong(songDto);
            Song newSong = await _songRepository.CreateAsync(song);


            foreach (var item in completeSong.AlbumIds)
            {
                var album = await _albumRepository.GetByIdAsync(item);
                AlbumSong albumSong = new AlbumSong();
                albumSong.AlbumID   = album.Id;
                albumSong.SongID    = song.Id;

                await _albumSongRepository.CreateAsync(albumSong);
            }

            //-- prepares the response
            CompleteSongResponse response = new CompleteSongResponse();
            response.SongId     = song.Id;
            response.Title      = song.Title;

            return response;
        }
    }
}


