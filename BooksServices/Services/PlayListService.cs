﻿using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Mappers;
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

        public PlayListService(IPlayListRepository playListRepository)
        {
            _playListRepository = playListRepository;
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

        public async Task<bool> CreatePlayListAsync(PlayListDto playListDto)
        {
            var playList =  PlayListMapper.MapPlayListDtoToPlayList(playListDto);
            return await _playListRepository.CreateAsync(playList);
        }

        public async Task<bool> UpdatePlayListAsync(PlayListDto playListDto)
        {
            var playList =  PlayListMapper.MapPlayListDtoToPlayList(playListDto);
            return await _playListRepository.UpdateAsync(playList);
        }

        public async Task<bool> DeletePlayListAsync(int id)
        {
            return await _playListRepository.DeleteAsync(id);
        }

    }
}