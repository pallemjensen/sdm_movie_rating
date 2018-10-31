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

        public SdmLib(TextReader reader)
        {
            LoadJson(reader);
            fillDictionaries();
        }

        public void LoadJson(TextReader reader)
        {
            using (reader)
            {
               string json = reader.ReadToEnd();
               List = JsonConvert.DeserializeObject<List<MovieRating>>(json);
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
        public int NumberOfReviewsFromN(int reviewer)
        {
            if (ReviewerReviews.ContainsKey(reviewer))
            {
                return ReviewerReviews[reviewer].Count;
            }

            return 0;
        }

        //2
        public double GetAverageRatingForReviewerN(int reviewer)
        {
            if (ReviewerReviews.ContainsKey(reviewer))
            {
                return ReviewerReviews[reviewer].Average();
            }

            return 0;
        }

        //3
        public int GetNumberOfGradeGForReviewerN(int reviewer, int grade)
        {
            //New Dictionary method
            if (ReviewerReviews.ContainsKey(reviewer))
            {
                List<int> number = ReviewerReviews[reviewer].FindAll(v => v == grade);
                return number.Count;
            }

            return 0;
        }

        //4
        public int NumberOfReviewsForMovieN(int movie)
        {
            if (MovieReviews.ContainsKey(movie))
            {
                return MovieReviews[movie].Count;
            }

            return 0;
        }

        //5
        public double AverageRatingForMovieN(int movie)
        {
            if (MovieReviews.ContainsKey(movie))
            {
                return MovieReviews[movie].Average();
            }

            return 0;
        }

        //6
        public int NumberOfGradeGForMovieN(int grade, int movie)
        {
            if (MovieReviews.ContainsKey(movie))
            {
                List<int> number = MovieReviews[movie].FindAll(v => v == grade);
                return number.Count;
            }

            return 0;
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
