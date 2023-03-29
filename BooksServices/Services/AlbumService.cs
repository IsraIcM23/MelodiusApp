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

        public async Task<bool> CreateAlbumAsync(AlbumDto album)
        {
            Album _album = AlbumMapper.MapAlbumDtoToAlbum(album);
            return await _albumRepository.CreateAsync(_album);
        }

        public async Task<bool> DeleteAlbumAsync(int id)
        {
            return await _albumRepository.DeleteAsync(id);
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

        public async Task<bool> UpdateAlbumAsync(AlbumDto album)
        {
            Album _album = AlbumMapper.MapAlbumDtoToAlbum(album);
            return await _albumRepository.UpdateAsync(_album);
        }
    }
}
