using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace sdm_movie_rating 
{
    public class SdmLib : ISdmLib
    {
        public IEnumerable<MovieRating> list;

        public SdmLib(string filepath)
        {
            LoadJson(filepath);
        }

        public void LoadJson(String filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
               string json = r.ReadToEnd();
               list = JsonConvert.DeserializeObject<List<MovieRating>>(json);
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
