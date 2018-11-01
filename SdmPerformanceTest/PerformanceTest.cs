using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmPerformanceTest
{
    [TestClass]
    public class SdmPerformanceTest
    {

        private static readonly string jsonFilePath = "/Users/morten/Documents/GitHub/sdm_movie_rating/sdm_movie_rating/ratings.json";

        private StreamReader r = new StreamReader(jsonFilePath);


        SdmLib sdmLib;

        public SdmPerformanceTest()
        {
            sdmLib = new SdmLib(r);
        }

        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            int result = sdmLib.NumberOfReviewsFromN(10);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);

        }

        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            double result = sdmLib.GetAverageRatingForReviewerN(10);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);

        }

        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            int result = sdmLib.GetNumberOfGradeGForReviewerN(10,5);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }


        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            int result = sdmLib.NumberOfReviewsFromN(1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //5
        [TestMethod]
        public void AverageRatingForMovieN_validNumber()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            double result = sdmLib.AverageRatingForMovieN(1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //6
        [TestMethod]
        public void NumberOfGradeGForMovieN()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            double result = sdmLib.NumberOfGradeGForMovieN(4, 1488844);

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }

        //7
        [TestMethod]
        public void IdsForMoviesWithTopRates()
        {
            Stopwatch sw = new Stopwatch();


            sw.Start();
            double result = sdmLib.IdsForMoviesWithTopRates()

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < 4000);
        }
       


    }
}
