using System;
using System.Collections.Generic;
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
        // FilePath must be changed for different file locations!!!
        //private static readonly string jsonFilePath = "C:\\Users\\Bruger\\ThirdSemester\\sdm_movie_rating\\ratings.json";
        //private StreamReader r = new StreamReader(jsonFilePath);

        //For use in unit tests
        private static string testString = "[" +
                                           "{ Reviewer:1, Movie:11, Grade:3, Date:'2005-09-06'}," +
                                           "{ Reviewer:1, Movie:22, Grade:5, Date:'2005-05-13'}," +
                                           "{ Reviewer:1, Movie:33, Grade:4, Date:'2005-10-19'}," +
                                           "{ Reviewer:1, Movie:44, Grade:4, Date:'2005-12-26'}," +
                                           "{ Reviewer:2, Movie:11, Grade:4, Date:'2005-09-05'}," +
                                           "{ Reviewer:2, Movie:22, Grade:3, Date:'2005-04-19'}," +
                                           "{ Reviewer:2, Movie:33, Grade:4, Date:'2005-04-22'}," +
                                           "{ Reviewer:2, Movie:44, Grade:5, Date:'2005-11-21'}," +
                                           "{ Reviewer:2, Movie:55, Grade:3, Date:'2004-11-13'}," +
                                           "{ Reviewer:3, Movie:11, Grade:5, Date:'2004-04-12'}," +
                                           "{ Reviewer:3, Movie:22, Grade:4, Date:'2005-07-18'}," +
                                           "{ Reviewer:3, Movie:33, Grade:4, Date:'2004-04-06'}," +
                                           "{ Reviewer:3, Movie:44, Grade:4, Date:'2005-07-19'}," +
                                           "{ Reviewer:3, Movie:55, Grade:3, Date:'2005-07-19'}," +
                                           "{ Reviewer:3, Movie:66, Grade:2, Date:'2004-06-16'}," +
                                           "{ Reviewer:4, Movie:11, Grade:3, Date:'2004-04-12'}," +
                                           "{ Reviewer:4, Movie:22, Grade:4, Date:'2005-07-18'}," +
                                           "{ Reviewer:4, Movie:33, Grade:4, Date:'2004-04-06'}," +
                                           "{ Reviewer:4, Movie:44, Grade:4, Date:'2005-07-19'}," +
                                           "{ Reviewer:4, Movie:55, Grade:4, Date:'2005-07-19'}," +
                                           "{ Reviewer:4, Movie:66, Grade:2, Date:'2004-06-16'}," +
                                           "{ Reviewer:4, Movie:77, Grade:3, Date:'2004-11-13'}," +
                                           "{ Reviewer:5, Movie:11, Grade:4, Date:'2004-04-12'}," +
                                           "{ Reviewer:5, Movie:22, Grade:4, Date:'2005-07-18'}," +
                                           "{ Reviewer:5, Movie:33, Grade:4, Date:'2004-04-06'}," +
                                           "{ Reviewer:5, Movie:44, Grade:3, Date:'2005-07-19'}," +
                                           "{ Reviewer:5, Movie:55, Grade:5, Date:'2005-07-19'}," +
                                           "{ Reviewer:5, Movie:66, Grade:1, Date:'2004-06-16'}," +
                                           "{ Reviewer:5, Movie:77, Grade:2, Date:'2004-11-13'}," +
                                           "{ Reviewer:5, Movie:88, Grade:3, Date:'2004-11-13'}," +
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
            int numEntries = 30;//4+5+6+7+8=30

            //number of entries in test data = 30
            Assert.AreEqual(numEntries, sdmLib.ListOfMovieRatings.Count());

        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            int ReviewsFromReviewer1 = 4;
            int ReviewsFromReviewer3 = 6;
            int ReviewsFromReviewer10 = 0;

            Assert.AreEqual(ReviewsFromReviewer1, sdmLib.NumberOfReviewsFromN(1));
            Assert.AreEqual(ReviewsFromReviewer3, sdmLib.NumberOfReviewsFromN(3));
            Assert.AreEqual(ReviewsFromReviewer10, sdmLib.NumberOfReviewsFromN(10));
        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRatingForReviewer1 = 4;
            double averageRatingForReviewer5 = 3.25;
            double averageRatingForReviewer10 = 0;

            Assert.AreEqual(averageRatingForReviewer1, sdmLib.GetAverageRatingForReviewerN(1));
            Assert.AreEqual(averageRatingForReviewer5, sdmLib.GetAverageRatingForReviewerN(5));
            Assert.AreEqual(averageRatingForReviewer10, sdmLib.GetAverageRatingForReviewerN(10));

        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            int numberOfGrade4ForReviewer1 = 2;
            int numberOfGrade4ForReviewer4 = 4;
            int numberOfGrade1ForReviewer2 = 0;

            Assert.AreEqual(numberOfGrade4ForReviewer1, sdmLib.GetNumberOfGradeGForReviewerN(1, 4));
            Assert.AreEqual(numberOfGrade4ForReviewer4, sdmLib.GetNumberOfGradeGForReviewerN(4, 4));
            Assert.AreEqual(numberOfGrade1ForReviewer2, sdmLib.GetNumberOfGradeGForReviewerN(2, 1));
        }

        //4
        [TestMethod]
        public void NumberOfReviewsForMovieN()
        {
            int numberOfReviewsForMovie11 = 5;
            int numberOfReviewsForMovie77 = 2;
            int numberOfReviewsForMovie101 = 0;

            Assert.AreEqual(numberOfReviewsForMovie11, sdmLib.NumberOfReviewsForMovieN(11));
            Assert.AreEqual(numberOfReviewsForMovie77, sdmLib.NumberOfReviewsForMovieN(77));
            Assert.AreEqual(numberOfReviewsForMovie101, sdmLib.NumberOfReviewsForMovieN(101));
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            double averageRatingForMovie11 = 3.8;
            double averageRatingForMovie77 = 2.5;
            double averageRatingForMovie707 = 0;

            Assert.AreEqual(averageRatingForMovie11, sdmLib.AverageRatingForMovieN(11));
            Assert.AreEqual(averageRatingForMovie77, sdmLib.AverageRatingForMovieN(77));
            Assert.AreEqual(averageRatingForMovie707, sdmLib.AverageRatingForMovieN(707));
        }

        //6
        [TestMethod]
        public void NumberOfGradeGForMovieN()
        {
            int NumberOfGrade4ForMovie33 = 5;
            int NumberOfGrade3ForMovie55 = 2;
            int NumberOfGrade2ForMovie11 = 0;
            int NumberOfGrade2ForMovie101 = 0;

            Assert.AreEqual(NumberOfGrade4ForMovie33, sdmLib.NumberOfGradeGForMovieN(4, 33));
            Assert.AreEqual(NumberOfGrade3ForMovie55, sdmLib.NumberOfGradeGForMovieN(3, 55));
            Assert.AreEqual(NumberOfGrade2ForMovie11, sdmLib.NumberOfGradeGForMovieN(2, 11));
            Assert.AreEqual(NumberOfGrade2ForMovie101, sdmLib.NumberOfGradeGForMovieN(2, 101));

        }

        //7
        [TestMethod]
        public void IdsForMoviesWithTopRates()
        {
            List<int> result = sdmLib.IdsForMoviesWithTopRates();
            Assert.IsTrue(result.Count == 4);
        }

        //8
        [TestMethod]
        public void ReviewersWithMostReviews()
        {
            List<int> result = sdmLib.ReviewersWithMostReviews();
            Assert.IsTrue(result.Count == 1);
        }

        //9
        [TestMethod]
        public void GetTopMovieIdsFromNNumberOfMovies()
        {
            int numRet = 3;
            List<int> result = sdmLib.GetTopMovieIdsFromNNumberOfMovies(numRet);
            Assert.AreEqual(numRet, result.Count);
        }

        //10
        [TestMethod]
        public void GetMoviesReviewedByNWithRateDecreasingDateIncreasing()
        {
            int reviewer = 5;
            List<int> result = sdmLib.GetMoviesReviewedByNWithRateDecreasingDateIncreasing(5);
            Assert.AreEqual(8, result.Count);
            foreach (var v in result)
            {
                Console.WriteLine("Movie id: "+ v);
            }
        }

        //11
        [TestMethod]
        public void GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing()
        {
            List<int> result = sdmLib.GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing(11);
            Assert.AreEqual(5, result.Count);

            foreach (var v in result)
            {
                Console.WriteLine("Reviewer id: " + v);
            }
        }

    }
}
