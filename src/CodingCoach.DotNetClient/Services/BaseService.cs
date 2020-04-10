namespace CodingCoach.DotNetClient.Services
{
    public class BaseService
    {
        public BaseService()
        {
            BaseUrl = new Configuration().Url;
        }

        protected string BaseUrl { get; set; }
    }
}