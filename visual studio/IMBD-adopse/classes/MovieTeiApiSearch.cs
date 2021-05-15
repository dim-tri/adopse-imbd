using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace IMBD_adopse.classes
{
    class MovieTeiApiSearch
    {

        private string query;

        public MovieTeiApiSearch(string query)
        {

            this.query = query;

        }


        public IEnumerable<Movie> Search()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://users.iee.ihu.gr/~it144346/moviesApiTei/api/v1/movies.php");
            HttpResponseMessage response = client.GetAsync("?s=" + this.query + "&pnum=0").Result;
            var mov = response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
            return mov;
        }




    }
}
