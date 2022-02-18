using dummy_api.Controllers;
using dummy_api.SongProviders;
using Moq;
using Xunit;

namespace dummy_api.Text.UnitTests.Controllers
{
    public class SongRecommenderController_Test
    {
        private SongRecommenderController _songRecommenderController;
        private Mock<ISongProvider> _songProviderMoq = new Mock<ISongProvider>(); 
        public SongRecommenderController_Test()
        {
        }

        [Fact]
        public void Index_Test()
        {
            _songProviderMoq.Setup(p => p.GetText()).Returns("");
            _songRecommenderController = new SongRecommenderController(null, _songProviderMoq.Object);

            Assert.Equal("Hello world", _songRecommenderController.Index());
        }

        [Fact]
        public void GetSongAsText_Test()
        {
            _songProviderMoq.Setup(p => p.GetText()).Returns("Never gonna give you up.");
            _songRecommenderController = new SongRecommenderController(null, _songProviderMoq.Object);

            Assert.Equal("Never gonna give you up.", _songRecommenderController.GetSongAsText());
        }

        [Fact]
        public void GetSongAsLink_Test()
        {
            _songProviderMoq.Setup(p => p.GetLink()).Returns("https://somelink.com");
            _songRecommenderController = new SongRecommenderController(null, _songProviderMoq.Object);

            Assert.Equal("https://somelink.com", _songRecommenderController.GetSongAsLink());
        }
    }
}
