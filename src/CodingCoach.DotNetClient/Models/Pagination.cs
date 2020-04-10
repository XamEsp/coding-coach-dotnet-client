namespace CodingCoach.DotNetClient.Models
{
    public class Pagination
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public bool HasMore { get; set; }
    }
}