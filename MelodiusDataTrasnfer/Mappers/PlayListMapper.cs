using MelodiusDataTrasnfer.DTOS;
using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Mappers
{
    public static class PlayListMapper
    {
        public static PlayListDto MapPlayListToPlayListDto(PlayList playList)
        {
            return new PlayListDto
            {
                Id = playList.Id,
                Title = playList.Title,
                DateOfCreation = playList.DateOfCreation,
                Description = playList.Description,
                IsPrivate = playList.IsPrivate,
                TotalLength = playList.TotalLength,
                UserId = playList.UserId
            };
        }

        public static PlayList MapPlayListDtoToPlayList(PlayListDto playListDto)
        {
            return new PlayList
            {
                Id = playListDto.Id,
                Title = playListDto.Title,
                DateOfCreation = playListDto.DateOfCreation,
                Description = playListDto.Description,
                IsPrivate = playListDto.IsPrivate,
                TotalLength = playListDto.TotalLength
            };
        }

        public static List<PlayListDto> MapPlayListsToPlayListDtos(List<PlayList> playLists)
        {
            return playLists.Select(playList => MapPlayListToPlayListDto(playList)).ToList();
        }

        public static List<PlayList> MapPlayListDtosToPlayLists(List<PlayListDto> playListDtos)
        {
            return playListDtos.Select(playListDto => MapPlayListDtoToPlayList(playListDto)).ToList();
        }
        
    }
}
