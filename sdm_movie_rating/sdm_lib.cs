using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sdm_movie_rating
{
    public class sdm_lib
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("ratings.json"))
            {
               string json = r.ReadToEnd();              

               IEnumerable<movie_rating> list = JsonConvert.DeserializeObject<List<movie_rating>>(json);

               Console.WriteLine(list.First());
            }
        }
    }
}
