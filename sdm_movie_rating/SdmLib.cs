using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace sdm_movie_rating 
{
    public class SdmLib : ISdmLib
    {
        public IEnumerable<MovieRating> ListOfMovieRatings;
        //Key=Reviewer  Value=MovieRating as List<MovieRating>
        public Dictionary<int, List<MovieRating>> ReviewerMovieRatings = new Dictionary<int, List<MovieRating>>();
        //Key=Reviewer  Value=Grade as List<int>
        public Dictionary<int, List<int>> ReviewerGrades = new Dictionary<int, List<int>>();
        //Key=Movie  Value=Grades as List<int>
        public Dictionary<int, List<int>> MovieGrades = new Dictionary<int, List<int>>();

        public SdmLib(TextReader reader)
        {
            LoadJson(reader);
            FillDictionaries();
        }

        public void LoadJson(TextReader reader)
        {
            using (reader)
            {
               string json = reader.ReadToEnd();
               ListOfMovieRatings = JsonConvert.DeserializeObject<List<MovieRating>>(json);
            }
        }

        private void FillDictionaries()
        {
            foreach (MovieRating mr in ListOfMovieRatings)
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
                if (ReviewerGrades.ContainsKey(reviewer))
                {
                    ReviewerGrades[reviewer].Add(mr.Grade);
                }
                else
                {
                    ReviewerGrades.Add(reviewer, new List<int>());
                    ReviewerGrades[reviewer].Add(mr.Grade);
                }
                //Fill MovieReviews<> Dictionary
                int movie = mr.Movie;

                if (MovieGrades.ContainsKey(movie))
                {
                    MovieGrades[movie].Add(mr.Grade);
                }
                else
                {
                    MovieGrades.Add(movie, new List<int>());
                    MovieGrades[movie].Add(mr.Grade);
                }

            }
        }

        //1
        public int NumberOfReviewsFromN(int reviewer)
        {
            if (ReviewerGrades.ContainsKey(reviewer))
            {
                return ReviewerGrades[reviewer].Count;
            }

            return 0;
        }

        //2
        public double GetAverageRatingForReviewerN(int reviewer)
        {
            if (ReviewerGrades.ContainsKey(reviewer))
            {
                return ReviewerGrades[reviewer].Average();
            }

            return 0;
        }

        //3
        public int GetNumberOfGradeGForReviewerN(int reviewer, int grade)
        {
            //New Dictionary method
            if (ReviewerGrades.ContainsKey(reviewer))
            {
                List<int> number = ReviewerGrades[reviewer].FindAll(v => v == grade);
                return number.Count;
            }

            return 0;
        }

        //4
        public int NumberOfReviewsForMovieN(int movie)
        {
            if (MovieGrades.ContainsKey(movie))
            {
                return MovieGrades[movie].Count;
            }

            return 0;
        }

        //5
        public double AverageRatingForMovieN(int movie)
        {
            if (MovieGrades.ContainsKey(movie))
            {
                return MovieGrades[movie].Average();
            }

            return 0;
        }

        //6
        public int NumberOfGradeGForMovieN(int grade, int movie)
        {
            if (MovieGrades.ContainsKey(movie))
            {
                List<int> number = MovieGrades[movie].FindAll(v => v == grade);
                return number.Count;
            }

            return 0;
        }

        //7
        public List<int> IdsForMoviesWithTopRates()
        {
            // Filtrerer fra listen, hvilke der er lig med 5. Hvad er det maximale af de counts. Så ved vi hvem der har flest 5'ere.
            int maxValue = ListOfMovieRatings.Where(r => r.Grade == 5).GroupBy(r => r.Movie).Max(r => r.Count());

            return ListOfMovieRatings.Where(r => r.Grade == 5).GroupBy(r => r.Movie).Where(r => r.Count() == maxValue).Select(r => r.Key).ToList();

        }

        //8
        public List<int> ReviewersWithMostReviews()
        {
            int maxValue = ListOfMovieRatings.GroupBy(r => r.Reviewer).Max(r => r.Count());

            return ListOfMovieRatings.GroupBy(r => r.Reviewer).Where(r => r.Count() == maxValue).Select(r => r.Key).ToList();
        }

        //9
        public List<int> GetTopMovieIdsFromNNumberOfMovies(int n)
        {
            return MovieGrades.OrderByDescending(v => v.Value.Average()).Take(n).Select(v => v.Key).ToList();
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
