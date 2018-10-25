using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdm_movie_rating;

namespace SdmTest
{
    [TestClass]
    public class SdmTest
    {
        [TestMethod]
        public void NumberOfReviewsFromNTest()
        {
            int x = 1488844;

            SdmLib sdmLib = new SdmLib("ratings.json");

            // Assert.IsNotNull(sdmLib.List.ElementAt(0));

            //Movie id at element 0 = 1488844
            Assert.AreEqual(sdmLib.List.ElementAt(0).Movie, x);

        }
    }
}
