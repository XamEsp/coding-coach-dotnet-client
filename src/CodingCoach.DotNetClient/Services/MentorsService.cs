using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingCoach.DotNetClient.Models;
using RestSharp;

namespace CodingCoach.DotNetClient.Services
{
    public class MentorsService : BaseService
    {
        public async Task<MentorsResponse> Get(MentorsRequest mentorsRequest = null)
        {
            var client = new RestClient(BaseUrl);

            var request = new RestRequest("mentors", DataFormat.Json);

            if (mentorsRequest != null)
            {
                if (mentorsRequest.Page > 0)
                    request.AddParameter("page", mentorsRequest.Page);
                if (mentorsRequest.Limit > 0)
                    request.AddParameter("limit", mentorsRequest.Limit);
                if (!string.IsNullOrWhiteSpace(mentorsRequest.Tags))
                    request.AddParameter("tags", mentorsRequest.Tags);
                if (!string.IsNullOrWhiteSpace(mentorsRequest.Country))
                    request.AddParameter("country", mentorsRequest.Country);
                if (!string.IsNullOrWhiteSpace(mentorsRequest.SpokenLanguages))
                    request.AddParameter("spokenLanguages", mentorsRequest.SpokenLanguages);
                if (!string.IsNullOrWhiteSpace(mentorsRequest.Name))
                    request.AddParameter("name", mentorsRequest.Name);
            }

            var response = await client.GetAsync<MentorsResponse>(request);

            return response;
        }
    }

    public class MentorsRequest
    {
        public MentorsRequest()
        {
            TagsList = new List<string>();
            SpokenLanguagesList = new List<string>();
        }

        public int Page { get; set; }
        public int Limit { get; set; }
        public IList<string> TagsList { get; set; }
        public string Tags => TagsList.Any() ? string.Concat(TagsList, ",") : "";
        public string Country { get; set; }
        public IList<string> SpokenLanguagesList { get; set; }
        public string SpokenLanguages => SpokenLanguagesList.Any() ? string.Concat(SpokenLanguagesList, ",") : "";
        public string Name { get; set; }
    }
}