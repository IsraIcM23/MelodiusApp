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
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }


        public async Task<int> CreateAlbumAsync(AlbumDto album)
        {
            Album _album = AlbumMapper.MapAlbumDtoToAlbum(album);
            var newAlbum = await _albumRepository.CreateAsync(_album);
            return newAlbum.Id;
        }

        public async Task<int> DeleteAlbumAsync(int id)
        {
            var deteledAlbum = await _albumRepository.DeleteAsync(id);
            return deteledAlbum.Id;
        }

        public async Task<AlbumDto> GetAlbumByIdAsync(int id)
        {
            var album = await _albumRepository.GetByIdAsync(id);
            return AlbumMapper.MapAlbumToAlbumDto(album);
        }

        public async Task<List<AlbumDto>> GetAllAlbumsAsync()
        {
            var albums = await _albumRepository.GetAllAsync();
            return AlbumMapper.MapAlbumsToAlbumsDtos(albums);
        }

        public async Task<AlbumDto> UpdateAlbumAsync(AlbumDto albumDto)
        {
            var albumModel = AlbumMapper.MapAlbumDtoToAlbum(albumDto);
            var album = await _albumRepository.UpdateAsync(albumModel);
            return AlbumMapper.MapAlbumToAlbumDto(album);
        }
    }
}
