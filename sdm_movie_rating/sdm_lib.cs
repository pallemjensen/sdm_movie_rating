using System;
using System.Collections.Generic;
using System.IO;
using static System.Runtime.Serialization.Json.JsonReaderWriterFactory;

namespace sdm_movie_rating
{
    public class sdm_lib
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("ratings.json"))
            {



                //string json = r.ReadToEnd();
                //List<movie_rating> movieratingList = JsonConvert.DeserializeObject<List<movie_rating>>(json);
            }
        }
    }
}
