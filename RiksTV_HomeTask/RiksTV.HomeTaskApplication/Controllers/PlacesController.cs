using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiksTV.HomeTaskApplication.Controllers
{
    using RiksTV.HomeTaskApplication.CacheProviderInterface;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface;

    [RoutePrefix("api")]
    public class PlacesController : ApiController
    {

        private IPlacesProvider placesProvider;

        private ICacheOperation cacheProvider;

        public PlacesController(IPlacesProvider placesProvider, ICacheOperation cacheProvider)
        {
            this.placesProvider = placesProvider;
            this.cacheProvider = cacheProvider;
        }

    }
}
