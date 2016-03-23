using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiksTV.HomeTaskApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiksTV.HomeTaskApplication.Controllers.Tests {
    using System.Runtime.Remoting;
    using System.Web.Http.Results;
    using System.Web.Mvc;
    using CacheProviderInterface;
    using Moq;
    using PlacesProviderInterface;
    using PlacesProviderInterface.Model;

    [TestClass()]
    public class ApiPlacesControllerTests {

        [TestMethod()]
        public void GetSearchTypesTestException() {
            Mock<ICacheOperation> mockCache = new Mock<ICacheOperation>();
            Mock<IPlacesProvider> mockProvider = new Mock<IPlacesProvider>();
            mockProvider.Setup(mp => mp.GetPlaceTypes()).Throws(new Exception());

            ApiPlacesController ctrl = new ApiPlacesController(mockProvider.Object, mockCache.Object);

            var result = ctrl.GetSearchTypes().Result;

            Assert.IsInstanceOfType(result, typeof(InternalServerErrorResult));
        }

        [TestMethod()]
        public void GetSearchTypesTestOK() {
            Mock<ICacheOperation> mockCache = new Mock<ICacheOperation>();
            Mock<IPlacesProvider> mockProvider = new Mock<IPlacesProvider>();
            mockProvider.Setup(mp => mp.GetPlaceTypes()).Returns(new List<PlaceType>() {new PlaceType() { DisplayName = "A", PlaceCode = "B" } });

            ApiPlacesController ctrl = new ApiPlacesController(mockProvider.Object, mockCache.Object);

            var result = ctrl.GetSearchTypes().Result;

            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<IEnumerable<PlaceType>>));

            var resultTyped = result as OkNegotiatedContentResult<IEnumerable<PlaceType>>;

            Assert.AreEqual(1, resultTyped.Content.Count());
        }
    }
}