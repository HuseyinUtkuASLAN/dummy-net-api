using dummy_api.SongProviders;
using Xunit;

namespace dummy_api.Text.UnitTests.SongProviders
{
    public class RickRollProvider_Test
    {
        private RickRollProvider _pickRollProvider;

        [Fact]
        public void GetText_Test()
        {
            _pickRollProvider = new RickRollProvider();

            Assert.Equal("Never gonna give you up.", _pickRollProvider.GetText());
        }

        [Fact]
        public void GetLink_Test()
        {
            _pickRollProvider = new RickRollProvider();

            Assert.Equal("https://somelink.com", _pickRollProvider.GetLink());
        }
    }
}
