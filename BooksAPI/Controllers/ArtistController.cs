using MelodiusDataTrasnfer.DTOS;
using MelodiusDataTrasnfer.Request;
using MelodiusDataTrasnfer.Responses;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService songService)
        {
            _artistService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArtists()
        {
            try
            {
                var artists = await _artistService.GetAllArtistsAsync();
                return Ok(artists);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtistById(int id)
        {
            var artist = await _artistService.GetArtistByIdAsync(id);
            return Ok(artist);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist(ArtistDto artist)
        {
            try
            {
                var result = await _artistService.CreateArtistAsync(artist);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArtist(ArtistDto artist)
        {
            var result = await _artistService.UpdateArtistAsync(artist);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            var result = await _artistService.DeleteArtistAsync(id);
            return Ok(result);
        }

        


    }
}
