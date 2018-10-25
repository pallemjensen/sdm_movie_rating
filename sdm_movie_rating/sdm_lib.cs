using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace sdm_movie_rating 
{
    public class SdmLib : ISdmLib
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("ratings.json"))
            {
               string json = r.ReadToEnd();              

               IEnumerable<MovieRating> list = JsonConvert.DeserializeObject<List<MovieRating>>(json);

               Console.WriteLine(list.First().Movie);
            }
        }

        public int NumberOfReviewsFromN(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRatingForReviewerN(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfGradeGForReviewerN(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }

        public int NumberOfReviewsForMovieN(int movie)
        {
            throw new NotImplementedException();
        }

        public double AverageRatingForMovieN(int movie)
        {
            throw new NotImplementedException();
        }

        public int NumberOfGradeGForMovieN(int grade, int movie)
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
