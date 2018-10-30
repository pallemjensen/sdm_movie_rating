using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        private Stopwatch sw = new Stopwatch();
        private static readonly string jsonFilePath = "C:\\Users\\Bruger\\ThirdSemester\\sdm_movie_rating\\ratings.json";
        private StreamReader r = new StreamReader(jsonFilePath);

        private static string testString = "[{ Reviewer:1, Movie:1488844, Grade:3, Date:'2005-09-06'}]";
        private StringReader testReader = new StringReader(testString);

        SdmLib sdmLib;

        public SdmTest()
        {
            sdmLib = new SdmLib(testReader);
            //Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
        }
        
        [TestMethod]
        public void PreliminaryTest()
        {
            /*
            sw.Start();
            // int x = 1488844;
            int x = 822109;
            // Number of entries in specific json file
            long numOfEntries = 5009439;
            */
            Assert.IsNotNull(sdmLib.List.ElementAt(0));
            /*
            //Movie id at element 1 = 822109
            Assert.AreEqual(sdmLib.List.ElementAt(1).Movie, x);
            //Number of entries = 5009439
            Assert.AreEqual(numOfEntries, sdmLib.List.LongCount());
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            */
        }
        
        
        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            //sw.Start();
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(1);

            Assert.IsNotNull(numberOfReviews);
            
        }
        
        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            double averageRating = sdmLib.GetAverageRatingForReviewerN(9);

            Assert.IsNotNull(averageRating);
            
        }
        
        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            //sw.Start();
            int numberOfGradeGForReviewerN = sdmLib.GetNumberOfGradeGForReviewerN(1, 3);

            Assert.IsNotNull(numberOfGradeGForReviewerN);
            Console.WriteLine(numberOfGradeGForReviewerN);
            /*
            for (int j = 10; j < 20; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Reviewer: "+j+" Grade: "+i+" times given = ");
                    Console.WriteLine(sdmLib.GetNumberOfGradeGForReviewerN(j, i));
                }
            }
            */
            //sw.Stop();
           // Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        
        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            //sw.Start();
            int numberOfReviews = sdmLib.NumberOfReviewsForMovieN(1488844);

            Assert.IsNotNull(numberOfReviews);
            Console.WriteLine(numberOfReviews);
            //sw.Stop();
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        /*
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
