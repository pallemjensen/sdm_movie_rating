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
        //Key=Reviewer  Value=MovieRating as List<MovieRating>
        public Dictionary<int, List<MovieRating>> ReviewerMovieRatings = new Dictionary<int, List<MovieRating>>();
        //Key=Reviewer  Value=Review as List<int>
        public Dictionary<int, List<int>> ReviewerReviews = new Dictionary<int, List<int>>();
        //Key=Movie  Value=Review as List<int>
        public Dictionary<int, List<int>> MovieReviews = new Dictionary<int, List<int>>();

        public SdmLib(TextReader r)
        {
            LoadJson(r);
        }

        public void LoadJson(TextReader r)
        {
            using (r)
            {
               string json = r.ReadToEnd();
               List = JsonConvert.DeserializeObject<List<MovieRating>>(json);
               fillDictionaries();
            }
        }
        
        private void fillDictionaries()
        {
            foreach (MovieRating mr in List)
            {
                int reviewer = mr.Reviewer;
                //Fill ReviewerMovieRatings<> Dictionary
                if (ReviewerMovieRatings.ContainsKey(reviewer))
                {
                    ReviewerMovieRatings[reviewer].Add(mr);
                }
                else
                {
                    ReviewerMovieRatings.Add(reviewer, new List<MovieRating>());
                    ReviewerMovieRatings[reviewer].Add(mr);
                }
                //Fill ReviewerReviews<> Dictionary
                if (ReviewerReviews.ContainsKey(reviewer))
                {
                    ReviewerReviews[reviewer].Add(mr.Grade);
                }
                else
                {
                    ReviewerReviews.Add(reviewer, new List<int>());
                    ReviewerReviews[reviewer].Add(mr.Grade);
                }
                //Fill MovieReviews<> Dictionary
                int movie = mr.Movie;

                if (MovieReviews.ContainsKey(movie))
                {
                    MovieReviews[movie].Add(mr.Grade);
                }
                else
                {
                    MovieReviews.Add(movie, new List<int>());
                    MovieReviews[movie].Add(mr.Grade);
                }

            }
        }

        //1
        public int NumberOfReviewsFromNReviewer(int reviewer)
        {
            //int numberOfReviews = 0;

            //int x = List.Count();

            //    for (int i = 0; i < x; i++)
            //    {
            //        if (List.ElementAt(i).Reviewer == reviewer)
            //        {
            //            numberOfReviews++;
            //        }
            //    }
            var numberOfReviews = (from list in List where list.Reviewer == reviewer select list.Movie).Count();
            return numberOfReviews;
        }

        //2
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

        //3
        public int GetNumberOfGradeGForReviewerN(int reviewer, int grade)
        {
           int result = 0;
           int x = List.Count();
 
            for (int i = 0; i < x; i++)
            {
                if (List.ElementAt(i).Reviewer == reviewer && List.ElementAt(i).Grade == grade)
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

            int x = List.Count();

            for (int i = 0; i < x; i++)
            {
                if (List.ElementAt(i).Movie == movie)
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

            int x = List.Count();

            int y = 0;

            double averageMovieRating = 0;

            for (int i = 0; i < x; i++)
            {
                if (List.ElementAt(i).Movie == movie)
                {
                    y++;
                    cumulativeMovieRating = cumulativeMovieRating + List.ElementAt(i).Grade;
                }
            }

            averageMovieRating = cumulativeMovieRating / y;

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
