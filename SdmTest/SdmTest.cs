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
        SdmLib sdmLib;

        public SdmTest()
        {
            sdmLib = new SdmLib(r);
            //Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
        }
        
        [TestMethod]
        public void PreliminaryTest()
        {
            sw.Start();
            // int x = 1488844;
            int x = 822109;
            // Number of entries in specific json file
            long numOfEntries = 5009439;

            // Assert.IsNotNull(sdmLib.List.ElementAt(0));

            //Movie id at element 1 = 822109
            Assert.AreEqual(sdmLib.List.ElementAt(1).Movie, x);
            //Number of entries = 5009439
            Assert.AreEqual(numOfEntries, sdmLib.List.LongCount());
            //sw.Stop();
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        
        
        //1
        [TestMethod]
        public void NumberOfReviewsFromNReviewer_validReviewNumber()
        {
            //sw.Start();
            int numberOfReviews = sdmLib.NumberOfReviewsFromNReviewer(9);

            Assert.IsNotNull(numberOfReviews);
            
            Console.WriteLine(numberOfReviews);
            //Console.WriteLine(sdmLib.NumberOfReviewsFromNReviewer(11));
            //sw.Stop();
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        
        //2
        [TestMethod]
        public void GetAverageRatingForReviewerN_validAverage()
        {
            //sw.Start();
            double averageRating = sdmLib.GetAverageRatingForReviewerN(9);

            Assert.IsNotNull(averageRating);
            Console.WriteLine(averageRating);
            /*
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("Average rating for reviewer"+ i +" = "+sdmLib.GetAverageRatingForReviewerN(i));
            }
            */
            //sw.Stop();
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        
        //3
        [TestMethod]
        public void GetNumberOfGradeGForReviewerN_validateNumber()
        {
            //sw.Start();
            int numberOfGradeGForReviewerN = sdmLib.GetNumberOfGradeGForReviewerN(10, 5);

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
            Console.WriteLine("TotalMilliSeconds elapsed: " + sw.Elapsed.TotalMilliseconds);
            //sw.Reset();
        }
        
        //4
        [TestMethod]
        public void numberOfReviewsForMovieN()
        {
            //sw.Start();
            int numberOfReviews = sdmLib.NumberOfReviewsForMovieN(1567202);

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
