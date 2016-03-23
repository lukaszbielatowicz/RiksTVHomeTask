namespace RiksTV.HomeTaskApplication.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Http;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ApiEmptyController : ApiController
    {
        /// <summary>
        /// Not found API get.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IHttpActionResult> NotFoundApiGet()
        {
            return this.NotFound();
        }

        /// <summary>
        /// Not found API post.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> NotFoundApiPost()
        {
            return this.NotFound();
        }

        /// <summary>
        /// Not found API put.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> NotFoundApiPut()
        {
            return this.NotFound();
        }

        /// <summary>
        /// Not found API delete.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IHttpActionResult> NotFoundApiDelete()
        {
            return this.NotFound();
        }
    }
}
