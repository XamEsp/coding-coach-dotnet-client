using System.Collections.Generic;

namespace CodingCoach.DotNetClient.Models
{
    public class MentorsResponse
    {
        public bool Success { get; set; }
        public Filters Filters { get; set; }
        public Pagination Pagination { get; set; }
        public List<Mentor> Data { get; set; }
    }
}
