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

        [TestMethod]
        public void NumberOfReviewsFromN_validReviewNumber()
        {
            int numberOfReviews = sdmLib.NumberOfReviewsFromN(10);

            Assert.IsNotNull(numberOfReviews);

            Console.WriteLine(numberOfReviews);
        }
    }
}
