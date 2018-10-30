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
        private static string testString = "[" +
                                           "{ Reviewer:1, Movie:1488844, Grade:3, Date:'2005-09-06'}," +
                                           "{ Reviewer:1, Movie:822109, Grade:5, Date:'2005-05-13'}," +
                                           "{ Reviewer:1, Movie:885013, Grade:4, Date:'2005-10-19'}," +
                                           "{ Reviewer:1, Movie:30878, Grade:4, Date:'2005-12-26'}," +
                                           "{ Reviewer:2, Movie:1488844, Grade:4, Date:'2005-09-05'}," +
                                           "{ Reviewer:2, Movie:1666394, Grade:3, Date:'2005-04-19'}," +
                                           "{ Reviewer:2, Movie:1759415, Grade:4, Date:'2005-04-22'}," +
                                           "{ Reviewer:2, Movie:1959936, Grade:5, Date:'2005-11-21'}," +
                                           "{ Reviewer:2, Movie:998862, Grade:4, Date:'2004-11-13'}," +
                                           "{ Reviewer:3, Movie:1488844, Grade:5, Date:'2004-04-12'}," +
                                           "{ Reviewer:3, Movie:2302997, Grade:4, Date:'2005-07-18'}," +
                                           "{ Reviewer:3, Movie:987085, Grade:4, Date:'2004-04-06'}," +
                                           "{ Reviewer:3, Movie:889134, Grade:4, Date:'2005-07-19'}," +
                                           "{ Reviewer:3, Movie:1904387, Grade:4, Date:'2005-07-19'}," +
                                           "{ Reviewer:3, Movie:1600392, Grade:2, Date:'2004-06-16'}" +
                                           "]";
        private StringReader testReader = new StringReader(testString);

        SdmLib sdmLib;

        public SdmTest()
        {
            sdmLib = new SdmLib(testReader);
        }

        [TestMethod]
        public void PreliminaryTest()
        {
            int numEntries = 15;//4+5+6=15

            //number of entries in test data = 15
            Assert.AreEqual(numEntries, sdmLib.List.Count());

        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int ReviewsFromReviewer1 = 4;
            int ReviewsFromReviewer3 = 6;

            Assert.AreEqual(ReviewsFromReviewer1, sdmLib.NumberOfReviewsFromNReviewer(1));
            Assert.AreEqual(ReviewsFromReviewer3, sdmLib.NumberOfReviewsFromNReviewer(3));
        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRatingForReviewer1 = 4;
            
            Assert.AreEqual(averageRatingForReviewer1, sdmLib.GetAverageRatingForReviewerN(1));
        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGrade4ForReviewer1 = 2;

            Assert.AreEqual(numberOfGrade4ForReviewer1, sdmLib.GetNumberOfGradeGForReviewerN(1, 4));
        }

        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            int numberOfReviewsForMovie1488844 = 3;

            Assert.AreEqual(numberOfReviewsForMovie1488844, sdmLib.NumberOfReviewsForMovieN(1488844));
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovie1488844 = 4;

            Assert.AreEqual(averageRatingForMovie1488844, sdmLib.AverageRatingForMovieN(1488844));
        }

    }
}
