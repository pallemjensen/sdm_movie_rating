using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using sdm_movie_rating;

namespace sdm_movie_rating 
{
    public class sdm_lib : Isdm_lib
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("ratings.json"))
            {
               string json = r.ReadToEnd();              

               IEnumerable<movie_rating> list = JsonConvert.DeserializeObject<List<movie_rating>>(json);

               Console.WriteLine(list.First().Movie);
            }
        }

        public int NumberOfReviewsFromN(int Reviewer)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRatingForReviewerN(int Reviewer)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfGradeGForReviewerN(int Reviewer, int Grade)
        {
            throw new NotImplementedException();
        }

        public int NumberOfReviewsForMovieN(int Movie)
        {
            throw new NotImplementedException();
        }

        public double AverageRatingForMovieN(int Movie)
        {
            throw new NotImplementedException();
        }

        public int NumberOfGradeGForMovieN(int Grade, int Movie)
        {
            throw new NotImplementedException();
        }

        public List<int> IdsForMoviesWithTopRates()
        {
            throw new NotImplementedException();
        }

        public List<int> ReviewersWithMostReviews()
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopMovieIdsFromNNumberOfMovies(int n)
        {
            throw new NotImplementedException();
        }

        public List<int> GetMoviesReviewedByNWithRateDecreasingDateIncreasing(int n)
        {
            throw new NotImplementedException();
        }

        public List<int> GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing(int movie)
        {
            throw new NotImplementedException();
        }
    }
}
