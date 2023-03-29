using MelodiusDataTrasnfer.DTOS;
using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Mappers
{
    public static class AlbumMapper
    {
        public static AlbumDto MapAlbumToAlbumDto(Album album)
        {
            return new AlbumDto
            {
                Id = album.Id,
                Title = album.Title,
                Description= album.Description
            };
        }

        public static Album MapAlbumDtoToAlbum(AlbumDto albumDto)
        {
            return new Album
            {
                Id = albumDto.Id,
                Title = albumDto.Title,
                Description = albumDto.Description
            };
        }

        public static List<AlbumDto> MapAlbumsToAlbumsDtos(List<Album> albums)
        {
            return albums.Select(album => MapAlbumToAlbumDto(album)).ToList();
        }

        public static List<Album> MapAlbumDtosToAlbums(List<AlbumDto> AlbumDtos)
        {
            return AlbumDtos.Select(albumDto => MapAlbumDtoToAlbum(albumDto)).ToList();
        }
    }
}
