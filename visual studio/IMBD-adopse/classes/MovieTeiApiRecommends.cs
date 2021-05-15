using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace IMBD_adopse.classes
{
    class MovieTeiApiRecommends
    {
        private int user_id;

        public MovieTeiApiRecommends(int uid)
        {
            this.user_id = uid;

        }

     
        public IEnumerable<Movie> recommends()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://users.iee.ihu.gr/~it144346/moviesApiTei/api/v1/movies.php");
                HttpResponseMessage response = client.GetAsync("?m=recommend&uid=" + this.user_id).Result;
                var mov = response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
                return mov;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
           
        }


    }
}
