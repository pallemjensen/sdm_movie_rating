using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace sdm_movie_rating 
{
    public class SdmLib : ISdmLib
    {
        //public Dictionary<int, MovieRating> Values = new Dictionary<int, MovieRating>();

        public Dictionary<int, MovieRating> Values = new Dictionary<int, MovieRating>();

        private int _allEntries;

        public int NumberOfEntries { get; private set; }

        public SdmLib(string filepath)
        {
            LoadJson(filepath);

        }

        public void LoadJson(String filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
                string jsonString = r.ReadToEnd();

                var values = JsonConvert.DeserializeObject<MovieRating>(jsonString);

                Values = new Dictionary<int, MovieRating>(_allEntries = values.Reviewer);

                NumberOfEntries = Values.Count;

                //Values = JsonConvert.DeserializeObject<Dictionary<int, MovieRating>>(json);

            }           
        }

        //1
        public int NumberOfReviewsFromNReviewer(int reviewer)
        {
            int numberOfReviews = 0;          
        
                for (int i = 0; i < _allEntries; i++)
                {
                    if (Values.ElementAt(i).Value.Reviewer == reviewer)
                    {
                        numberOfReviews++;
                    }
                }
                         
            return numberOfReviews;
        }

        //2
        public double GetAverageRatingForReviewerN(int reviewer)
        {
            double cumulativeRating = 0;
          
            int y = 0;

            for (int i = 0; i < _allEntries; i++)
            {
                if (Values.ElementAt(i).Value.Reviewer == reviewer)
                {
                  y++;
                  cumulativeRating  = cumulativeRating + Values.ElementAt(i).Value.Grade;
                }

            }
            var averageRating = cumulativeRating / y;

            return averageRating;
        }

        //3
        public int GetNumberOfGradeGForReviewerN(int reviewer, int grade)
        {
           int result = 0;

            for (int i = 0; i < _allEntries; i++)
            {
                if (Values.ElementAt(i).Value.Reviewer == reviewer && Values.ElementAt(i).Value.Grade == grade)
                {
                    result++;                  
                }
            }
            return result;
        }

        //4
        public int NumberOfReviewsForMovieN(int movie)
        {
            int numberOfReviews = 0;

            for (int i = 0; i < _allEntries; i++)
            {
                if (Values.ElementAt(i).Value.Movie == movie)
                {
                    numberOfReviews++;
                }
            }
            return numberOfReviews;
        }

        //5
        public double AverageRatingForMovieN(int movie)
        {
            double cumulativeMovieRating = 0;

            int y = 0;

            for (int i = 0; i < _allEntries; i++)
            {
                if (Values.ElementAt(i).Value.Movie == movie)
                {
                    y++;
                    cumulativeMovieRating = cumulativeMovieRating + Values.ElementAt(i).Value.Grade;
                }
            }

            var averageMovieRating = cumulativeMovieRating / y;

            return averageMovieRating;
        }

        //6
        public int NumberOfGradeGForMovieN(int grade, int movie)
        {
            throw new NotImplementedException();
        }

        //7
        public List<int> IdsForMoviesWithTopRates()
        {
            throw new NotImplementedException();
        }

        //8
        public List<int> ReviewersWithMostReviews()
        {
            throw new NotImplementedException();
        }

        //9
        public List<int> GetTopMovieIdsFromNNumberOfMovies(int n)
        {
            throw new NotImplementedException();
        }

        //10
        public List<int> GetMoviesReviewedByNWithRateDecreasingDateIncreasing(int n)
        {
            throw new NotImplementedException();
        }

        //11
        public List<int> GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing(int movie)
        {
            throw new NotImplementedException();
        }
    }
}
