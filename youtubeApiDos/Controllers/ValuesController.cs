using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace youtubeApiDos.Controllers
{
    public class ValuesController : ApiController
    {
        public List<SearchResult> Get(string SearchWord)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBk-aJoF8M0iUTbK4ByY1q9j-7z3_2DvVQ",
                ApplicationName = this.GetType().ToString()
            });

            var SearchListRequest = youtubeService.Search.List("snippet");
            SearchListRequest.Q = SearchWord;
            SearchListRequest.MaxResults = 10;

            var SearchListResponse = SearchListRequest.Execute();
            return SearchListResponse.Items.ToList();

            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
