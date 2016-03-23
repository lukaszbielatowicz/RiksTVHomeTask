namespace RiksTV.HomeTaskApplication.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    using RiksTV.HomeTaskApplication.CacheProviderInterface;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("api/places")]
    public class ApiPlacesController : ApiController
    {

        /// <summary>
        /// The places provider
        /// </summary>
        private readonly IPlacesProvider placesProvider;

        /// <summary>
        /// The cache provider
        /// </summary>
        private readonly ICacheOperation cacheProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPlacesController"/> class.
        /// </summary>
        /// <param name="placesProvider">The places provider.</param>
        /// <param name="cacheProvider">The cache provider.</param>
        public ApiPlacesController(IPlacesProvider placesProvider, ICacheOperation cacheProvider)
        {
            this.placesProvider = placesProvider;
            this.cacheProvider = cacheProvider;
        }

        /// <summary>
        /// Gets the search types.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getsearchtypes")]
        public async Task<IHttpActionResult> GetSearchTypes()
        {
            try
            {
                var response = this.placesProvider.GetPlaceTypes();
                return this.Ok(response);
            }
            catch (Exception)
            {
                // TODO: add error log, and put some response to user
                return this.InternalServerError();
            }
        }
    }

    //private class helper
    //{
    //    // GET api/values
    //    public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    // GET api/values/5
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/values
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT api/values/5
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE api/values/5
    //    public void Delete(int id)
    //    {
    //    }
    //}
}
