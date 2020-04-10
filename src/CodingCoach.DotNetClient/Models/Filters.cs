using System.Collections.Generic;

namespace CodingCoach.DotNetClient.Models
{
    public class Filters
    {
        public List<Country> Countries { get; set; }
        public List<Language> Languages { get; set; }
        public List<string> Technologies { get; set; }
    }
}