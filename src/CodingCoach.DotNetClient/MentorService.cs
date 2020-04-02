using RestSharp;

namespace CodingCoach.DotNetClient
{
    public class MentorsService
    {
        public string Get()
        {
            var client = new RestClient("https://api-staging.codingcoach.io");

            var request = new RestRequest("mentors", DataFormat.Json);

            var response = client.Get(request);

            return response.Content;
        }
    }
}
