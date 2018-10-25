using System;
using System.Collections.Generic;
using System.Text;

namespace sdm_movie_rating
{
    public interface Isdm_lib
    {
        //1
        int NumberOfReviewsFromN(int Reviewer);

        //2
        double GetAverageRatingForReviewerN(int Reviewer);

        //3
        int GetNumberOfGradeGForReviewerN(int Reviewer, int Grade);

        //
        int NumberOfReviewsForMovieN(int Movie);

        //5
        double AverageRatingForMovieN(int Movie);

        //6
        int NumberOfGradeGForMovieN(int Grade, int Movie);

        //7  
        List<int> IdsForMoviesWithTopRates();

        //8
        List<int> ReviewersWithMostReviews();

        //9
        List<int> GetTopMovieIdsFromNNumberOfMovies(int n);

        //10
        List<int> GetMoviesReviewedByNWithRateDecreasingDateIncreasing(int n);

        //11
        List<int> GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing(int movie);

    }
}
