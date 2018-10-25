using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace sdm_movie_rating 
{
    public class SdmLib : ISdmLib
    {
        public IEnumerable<MovieRating> List;

        public SdmLib(string filepath)
        {
            LoadJson(filepath);
        }

        public void LoadJson(String filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
               string json = r.ReadToEnd();
               List = JsonConvert.DeserializeObject<List<MovieRating>>(json);
            }
        }

        public int NumberOfReviewsFromN(int reviewer)
        {
            int numberOfReviews = 0;

            int x = List.Count();
        
                for (int i = 0; i < x; i++)
                {
                    if (List.ElementAt(i).Reviewer == reviewer)
                    {
                        numberOfReviews++;
                    }
                }
                         
            return numberOfReviews;
        }

        public double GetAverageRatingForReviewerN(int reviewer)
        {
            double averageRating = 0;

            //can be int, but resharper is annoyed
            double cumulativeRating = 0;

            int x = List.Count();

            int y = 0;

            for (int i = 0; i < x; i++)
            {
                if (List.ElementAt(i).Reviewer == reviewer)
                {
                  y++;
                  cumulativeRating  = cumulativeRating + List.ElementAt(i).Grade;
                }

            }
            averageRating = cumulativeRating / y;

            return averageRating;
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
