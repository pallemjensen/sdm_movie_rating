using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        private static readonly string jsonFilePath = "C:\\Users\\Bruger\\ThirdSemester\\sdm_movie_rating\\ratings.json";

        SdmLib sdmLib = new SdmLib(jsonFilePath);

        [TestMethod]
        public void PreliminaryTest()
        {
           // int x = 1488844;
            int x = 822109;
            // Number of entries in specific json file
            long numOfEntries = 5009439;

            // Assert.IsNotNull(sdmLib.List.ElementAt(0));

            //Movie id at element 1 = 822109
            Assert.AreEqual(sdmLib.List.ElementAt(1).Movie, x);

            Assert.AreEqual(numOfEntries, sdmLib.List.LongCount());

        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(10);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }
        /*
        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRating = sdmLib.GetAverageRatingForReviewerN(10);

            Assert.IsNotNull(averageRating);

            Console.WriteLine(averageRating);
        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGradeGForReviewerN = sdmLib.GetNumberOfGradeGForReviewerN(10, 5);

            Assert.IsNotNull(numberOfGradeGForReviewerN);

            Console.WriteLine(numberOfGradeGForReviewerN);
        }

        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsForMovieN(1567202);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovieN = sdmLib.AverageRatingForMovieN(1567202);

            Assert.IsNotNull(averageRatingForMovieN);

            Console.WriteLine(averageRatingForMovieN);
        }
        */
    }
}
