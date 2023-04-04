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
using System.Collections;
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
        private readonly IPlayListRepository _playListRepository;

        private readonly IAlbumSongRepository _albumSongRepository;
        private readonly IPlayListSongRepository _playListSongRepository;


        public SongService(ISongRepository songRepository, IAlbumRepository albumRepository, IPlayListRepository playListRepository ,IAlbumSongRepository albumSongRepository, IPlayListSongRepository playListSongRepository)
        {
            _songRepository = songRepository;
            _albumRepository = albumRepository;
            _albumSongRepository = albumSongRepository;

            _playListSongRepository = playListSongRepository;
            _playListRepository = playListRepository;
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
            List<int> albumSongs = new List<int>();
            List<int> playListSongs = new List<int>();


            foreach (var item in completeSong.AlbumIds)
            {
                var album = await _albumRepository.GetByIdAsync(item);
                AlbumSong albumSong = new AlbumSong();
                albumSong.AlbumID   = album.Id;
                albumSong.SongID    = newSong.Id;
                await _albumSongRepository.CreateAsync(albumSong);

                var albums = await _albumSongRepository.GetByIdAsync(albumSong.Id);
                albumSongs.Add(albums.AlbumID);
            }

            foreach (var item in completeSong.PlayListIds)
            {
                var playList = await _playListRepository.GetByIdAsync(item);
                PlayListSong playListSong = new PlayListSong();
                playListSong.PlaylistID = playList.Id;
                playListSong.SongID = newSong.Id;
                await _playListSongRepository.CreateAsync(playListSong);

                var playlists = await _playListSongRepository.GetByIdAsync(playListSong.Id);
                playListSongs.Add(playlists.PlaylistID);
            }




            //-- prepares the response
            CompleteSongResponse response = new CompleteSongResponse();
            response.SongId     = newSong.Id;
            response.Title      = newSong.Title;
            response.albumIds   = albumSongs;
            response.PlayListIds = playListSongs;

            return response;
        }


    }
}


