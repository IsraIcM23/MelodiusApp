using BooksModels;
using MelodiusDataTrasnfer.DTOS;
using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Mappers
{
    public static class SongMapper
    {
        public static SongDto MapSongToSongDto(Song song)
        {
            return new SongDto
            {
                Id = song.Id,
                Title = song.Title,
                Genre = song.Genre,
                ReleaseDate = song.ReleaseDate,
                Length = song.Length
            };
        }

        public static Song MapSongDtoToSong(SongDto songDto)
        {
            return new Song
            {
                Id = songDto.Id,
                Title = songDto.Title,
                Genre = songDto.Genre,
                ReleaseDate = songDto.ReleaseDate,
                Length = songDto.Length
            };
        }

        public static List<SongDto> MapSongsToSongsDtos(List<Song> songs)
        {
            return songs.Select(song => MapSongToSongDto(song)).ToList();
        }

        public static List<Song> MapSongDtosToSongs(List<SongDto> songDtos)
        {
            return songDtos.Select(songDto => MapSongDtoToSong(songDto)).ToList();
        }
    }
}
