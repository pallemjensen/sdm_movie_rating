using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        private readonly SdmLib _sdmLib = new SdmLib("ratings.json");
       
       
        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int numberOfReviews = _sdmLib.NumberOfReviewsFromNReviewer(10);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRating = _sdmLib.GetAverageRatingForReviewerN(10);

            Assert.IsNotNull(averageRating);

            Console.WriteLine(averageRating);
        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGradeGForReviewerN = _sdmLib.GetNumberOfGradeGForReviewerN(10, 5);

            Assert.IsNotNull(numberOfGradeGForReviewerN);

            Console.WriteLine(numberOfGradeGForReviewerN);
        }

        //4
        [TestMethod]
        public void NumberOfReviewsForMovieN()
        {
            int numberOfReviews = _sdmLib.NumberOfReviewsForMovieN(1567202);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovieN = _sdmLib.AverageRatingForMovieN(1567202);

            Assert.IsNotNull(averageRatingForMovieN);

            Console.WriteLine(averageRatingForMovieN);
        }

    }
}
