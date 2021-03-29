using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Newtonsoft.Json;

namespace IMBD_adopse.classes
{
    class ApiClient
    {
        private string url;
        private string request;

        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string imdbRating { get; set; }
        public string imdbID { get; set; }
        public string Production { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }




        public ApiClient(string url,string request)
        {
            this.url = url;
            this.request = request;
        }

        public string Url   
        {
            get { return url; }   
            set { url = value; }  
        }

        public string Request
        {
            get { return request; }
            set { request = value; }
        }

        public ApiClient getData()
        {
            var client = new RestClient(this.Url);
            var request = new RestRequest(this.Request);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                string rawResponse = response.Content;
                ApiClient result = JsonConvert.DeserializeObject<ApiClient>(rawResponse);
                return result;
            }
            
            return null;
        }

    }
}
