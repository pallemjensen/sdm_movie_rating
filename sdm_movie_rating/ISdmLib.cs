using System.Collections.Generic;

namespace sdm_movie_rating
{
    public interface ISdmLib
    {
        //1
        int NumberOfReviewsFromNReviewer(int reviewer);

        //2
        double GetAverageRatingForReviewerN(int reviewer);

        //3
        int GetNumberOfGradeGForReviewerN(int reviewer, int grade);

        //4
        int NumberOfReviewsForMovieN(int movie);

        //5
        double AverageRatingForMovieN(int movie);

        //6
        int NumberOfGradeGForMovieN(int grade, int movie);

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
