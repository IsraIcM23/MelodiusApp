using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Request;
using MelodiusDataTrasnfer.Responses;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSongs()
        {
            try
            {
                var users = await _songService.GetAllSongsAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSongById(int id)
        {
            var song = await _songService.GetSongByIdAsync(id);
            return Ok(song);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSong(SongDto song)
        {
            try
            {
                var result = await _songService.CreateSongAsync(song);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSong(SongDto song)
        {
            var result = await _songService.UpdateSongAsync(song);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSong(int id)
        {
            var result = await _songService.DeleteSongAsync(id);
            return Ok(result);
        }

        [HttpPost("CompleteSong")]
        public async Task<ActionResult<CompleteSongResponse>> AddNewSong(CompleteSongRequest song)
        {
            try
            {
                var response = await _songService.AddCompleteSong(song);
                return Ok(response);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }



    }
}
