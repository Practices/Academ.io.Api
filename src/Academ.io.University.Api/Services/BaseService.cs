using RestSharp;

namespace Academ.io.University.Api.Services
{
    public class BaseService
    {
        private const string BaseUrl = "https://eu.bmstu.ru";

        public BaseService()
        {
            Client = new RestClient(BaseUrl);
        }

        protected RestClient Client { get; set; }

        protected RestRequest GetRequest(string url)
        {
            return new RestRequest
                       {
                               Resource = url,
                               Method = Method.GET,
                               RequestFormat = DataFormat.Xml
                       };
        }
    }
}