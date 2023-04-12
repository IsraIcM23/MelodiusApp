using MelodiusDataTrasnfer.DTOS;
using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Mappers
{
    public static class ArtistMapper
    {
        public static ArtistDto MapArtistToArtistDto(Artist artist)
        {
            return new ArtistDto
            {
                Id = artist.Id,
                Name = artist.Name,
                Biography = artist.Biography
            };
        }

        public static Artist MapArtistDtoToArtist(ArtistDto artistDto)
        {
            return new Artist
            {
                Id = artistDto.Id,
                Name = artistDto.Name,
                Biography = artistDto.Biography
                
            };
        }

        public static List<ArtistDto> MapArtistsToArtistDtos(List<Artist> artists)
        {
            return artists.Select(artist => MapArtistToArtistDto(artist)).ToList();
        }

        public static List<Artist> MapPlayListDtosToPlayLists(List<ArtistDto> artistDtos)
        {
            return artistDtos.Select(artistDto => MapArtistDtoToArtist(artistDto)).ToList();
        }

    }
}
