namespace dummy_api.SongProviders
{
    public class RickRollProvider : ISongProvider
    {
        public string GetText()
        {
            return "Never gonna give you up.";
        }

        public string GetLink()
        {
            return "https://somelink.com";
        }
    }
}
