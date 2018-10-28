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
        public Dictionary<int, List<MovieRating>> Reviewers = new Dictionary<int, List<MovieRating>>();
        //private int nr = test[111].Count;
        public SdmLib(string filepath)
        {
            LoadJson(filepath);
            fillDictionaries();
        }

        public void LoadJson(String filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
               string json = r.ReadToEnd();
               List = JsonConvert.DeserializeObject<List<MovieRating>>(json);
            }
        }

        private void fillDictionaries()
        {
            foreach (MovieRating mr in List)
            {
                int reviewer = mr.Reviewer;
                if (Reviewers.ContainsKey(reviewer))
                {
                    Reviewers[reviewer].Add(mr);
                }
                else
                {
                    Reviewers.Add(reviewer,new List<MovieRating>());
                    Reviewers[reviewer].Add(mr);
                }
            }
        }

        //1
        public int NumberOfReviewsFromNReviewer(int reviewer)
        {
            return Reviewers[reviewer].Count;

            //int numberOfReviews = 0;

            //int x = List.Count();

            //    for (int i = 0; i < x; i++)
            //    {
            //        if (List.ElementAt(i).Reviewer == reviewer)
            //        {
            //            numberOfReviews++;
            //        }
            //    }
            //var numberOfReviews = (from list in List where list.Reviewer == reviewer select list.Movie).Count();
            //return numberOfReviews;
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
