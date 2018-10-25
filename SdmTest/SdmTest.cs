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

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(10);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }

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

    }
}
