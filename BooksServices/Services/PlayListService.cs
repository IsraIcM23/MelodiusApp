using BooksModels;
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
    public class PlayListService : IPlayListService
    {
        private readonly IPlayListRepository _playListRepository;
        private readonly IUserRepository _userRepository;
        private IPlayListSongRepository _playListSongRepository;

        public PlayListService(IPlayListRepository playListRepository, IUserRepository userRepository)
        {
            _playListRepository = playListRepository;
            _userRepository = userRepository;
        }

        public async Task<List<PlayListDto>> GetAllPlayListsAsync()
        {
            var playLists = await _playListRepository.GetAllAsync();
            return PlayListMapper.MapPlayListsToPlayListDtos(playLists);

        }

        public async Task<PlayListDto> GetPlayListByIdAsync(int id)
        {
            var playList = await _playListRepository.GetByIdAsync(id);
            return PlayListMapper.MapPlayListToPlayListDto(playList);
        }


        public async Task<int> CreatePlayListAsync(PlayListDto playListDto)
        {
            //var playList = PlayListMapper.MapPlayListDtoToPlayList(playListDto);
            //var user = await _userRepository.GetByIdAsync(playListDto.UserId);
            //playList.User = user;
            //return await _playListRepository.CreateAsync(playList);


            PlayList _playList = PlayListMapper.MapPlayListDtoToPlayList(playListDto);
            var newPlayList = await _playListRepository.CreateAsync(_playList);
            return newPlayList.Id;

        }

        public async Task<PlayListDto> UpdatePlayListAsync(PlayListDto playListDto)
        {
            var playListModel = PlayListMapper.MapPlayListDtoToPlayList(playListDto);
            var playList = await _playListRepository.UpdateAsync(playListModel);
            return PlayListMapper.MapPlayListToPlayListDto(playList);
        }

        public async Task<int> DeletePlayListAsync(int id)
        {
            var deletePlayList = await _playListRepository.DeleteAsync(id);
            return deletePlayList.Id;
        }

    }
}
