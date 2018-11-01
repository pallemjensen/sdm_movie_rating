using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmPerformanceTest
{
    [TestClass]
    public class SdmPerformanceTest
    {
        //Palle
        private static readonly string jsonFilePath =
            "C:\\Users\\pmj\\Dropbox\\Studie\\3. semester\\software development methodologies\\MovieRatingDev\\sdm_movie_rating\\SdmTest\\obj\\Debug\\netcoreapp2.1\\ratings.json";
        //Sven
        //private static readonly string jsonFilePath = "C:\\Users\\Bruger\\ThirdSemester\\sdm_movie_rating\\ratings.json";


        private readonly StreamReader r = new StreamReader(jsonFilePath);


        private readonly SdmLib sdmLib;

        public SdmPerformanceTest()
        {
            sdmLib = new SdmLib(r);
        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.NumberOfReviewsFromN(10);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.GetAverageRatingForReviewerN(10);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.GetNumberOfGradeGForReviewerN(10, 5);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }


        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.NumberOfReviewsFromN(1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.AverageRatingForMovieN(1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //6
        [TestMethod]
        public void NumberOfGradeGForMovieN()
        {
            var sw = new Stopwatch();


            sw.Start();
            double result = sdmLib.NumberOfGradeGForMovieN(4, 1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //7
        [TestMethod]
        public void IdsForMoviesWithTopRates()
        {
            var sw = new Stopwatch();


            sw.Start();
            var result = sdmLib.IdsForMoviesWithTopRates();

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //8
        [TestMethod]
        public void ReviewersWithMostReviews()
        {
            var sw = new Stopwatch();


            sw.Start();

            var result = sdmLib.ReviewersWithMostReviews();

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }


        //9
        [TestMethod]
        public void GetTopMovieIdsFromNNumberOfMovies()
        {
            var sw = new Stopwatch();


            sw.Start();

            var result = sdmLib.GetTopMovieIdsFromNNumberOfMovies(3);
            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //10
        [TestMethod]
        public void GetMoviesReviewedByNWithRateDecreasingDateIncreasing()
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = sdmLib.GetMoviesReviewedByNWithRateDecreasingDateIncreasing(10);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //11
        [TestMethod]
        public void GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing()
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = sdmLib.GetReviewersWhoReviewedMovieNWithRateDecreasingDateIncreasing(1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }
    }
}