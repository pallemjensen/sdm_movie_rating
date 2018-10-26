using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        SdmLib sdmLib = new SdmLib("ratings.json");

        [TestMethod]
        public void PreliminaryTest()
        {
           // int x = 1488844;
            int x = 822109;


            // Assert.IsNotNull(sdmLib.List.ElementAt(0));

            //Movie id at element 1 = 822109
            Assert.AreEqual(sdmLib.List.ElementAt(1).Movie, x);

        }

        //1 On input N, what are the number of reviews from reviewer N?
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(10);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

        //2 - . On input N, what is the average rate that reviewer N had given?
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRating = sdmLib.GetAverageRatingForReviewerN(10);

            Assert.IsNotNull(averageRating);

            Console.WriteLine(averageRating);
        }

        //3 - On input N and G, how many times has reviewer N given a movie grade G?
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGradeGForReviewerN = sdmLib.GetNumberOfGradeGForReviewerN(10, 5);

            Assert.IsNotNull(numberOfGradeGForReviewerN);

            Console.WriteLine(numberOfGradeGForReviewerN);
        }

        //4 - On input N, how many have reviewed movie N?
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsForMovieN(1567202);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

        //5 - On input N, what is the average rate the movie N had received?
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovieN = sdmLib.AverageRatingForMovieN(1567202);

            Assert.IsNotNull(averageRatingForMovieN);

            Console.WriteLine(averageRatingForMovieN);
        }

        // 6 - On input N and G, how many times had movie N received grade G?
        [TestMethod]
        public void  NumberOfTimesMovieRecievedGradeG()
        {
            // movie 869924
            // rating 5

            int numberOfTimesMovieNReceivedGradeG = sdmLib.NumberOfGradeGForMovieN(869924, 5);

            Assert.IsNotNull(numberOfTimesMovieNReceivedGradeG);

            Console.WriteLine(numberOfTimesMovieNReceivedGradeG);

        }

    }
}
