using System;
using System.Collections.Generic;

namespace CodingCoach.DotNetClient.Models
{
    public class Mentor
    {
        public string Id { get; set; }
        public bool Available { get; set; }
        public List<string> SpokenLanguages { get; set; }
        public List<string> Tags { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<object> Channels { get; set; }
    }
}