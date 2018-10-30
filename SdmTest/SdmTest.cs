using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        //For use in integration tests
        // FilePath must be changed for different users!!!
        private static readonly string jsonFilePath = "C:\\Users\\Bruger\\ThirdSemester\\sdm_movie_rating\\ratings.json";
        private StreamReader r = new StreamReader(jsonFilePath);

        //For use in unit tests
        private static string testString = "[{ Reviewer:1, Movie:1488844, Grade:3, Date:'2005-09-06'}]";
        private StringReader testReader = new StringReader(testString);

        SdmLib sdmLib;

        public SdmTest()
        {
            sdmLib = new SdmLib(testReader);
        }

        [TestMethod]
        public void PreliminaryTest()
        {
            int x = 1488844;

            //Movie id at element 0 = 1488844
            Assert.AreEqual(sdmLib.List.ElementAt(0).Movie, x);

        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(1);

            Assert.AreEqual(1, numberOfReviews);
        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRating = sdmLib.GetAverageRatingForReviewerN(1);
            
            Assert.AreEqual(3, averageRating);
        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGradeGForReviewerN = sdmLib.GetNumberOfGradeGForReviewerN(1, 3);

            Assert.AreEqual(1, numberOfGradeGForReviewerN);
        }

        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsForMovieN(1488844);

            Assert.AreEqual(1, numberOfReviews);
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovieN = sdmLib.AverageRatingForMovieN(1488844);

            Assert.AreEqual(3, averageRatingForMovieN);
        }

    }
}
