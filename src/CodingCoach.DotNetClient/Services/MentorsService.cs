using System.Threading.Tasks;
using CodingCoach.DotNetClient.Models;
using RestSharp;

namespace CodingCoach.DotNetClient.Services
{
    public class MentorsService : BaseService
    {
        public async Task<MentorsResponse> Get()
        {
            var client = new RestClient(BaseUrl);

            var request = new RestRequest("mentors", DataFormat.Json);

            var response = await client.GetAsync<MentorsResponse>(request);

            return response;
        }
    }
}