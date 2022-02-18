using dummy_api.SongProviders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace dummy_api.Controllers
{
    [ApiController]
    [Route("")]
    public class SongRecommenderController : ControllerBase
    {
        private readonly ILogger<SongRecommenderController> _logger;
        private readonly ISongProvider _songProvider;
        public SongRecommenderController(ILogger<SongRecommenderController> logger, ISongProvider songProvider)
        {
            _logger = logger;
            _songProvider = songProvider;
        }

        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello world";
        }

        [HttpGet]
        [Route("song-text")]
        public string GetSongAsText()
        {
            return _songProvider.GetText();
        }

        [HttpGet]
        [Route("song-link")]
        public string GetSongAsLink()
        {
            return _songProvider.GetLink();
        }
    }
}
