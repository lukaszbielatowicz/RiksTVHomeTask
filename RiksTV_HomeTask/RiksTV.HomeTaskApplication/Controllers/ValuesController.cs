using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiksTV.HomeTaskApplication.Controllers {
    using System.Threading.Tasks;

    public class ValuesController : ApiController {
        // GET api/values
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id) {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }
    }

    [RoutePrefix("api")]
    public class TestApiController : ApiController
    {

        [HttpGet]
        [Route("auth")]
        public async Task<IHttpActionResult> TestAuth()
        {
            //FormsAuthentication.SetAuthCookie("X131214", true);
            return Ok();
        }

        [HttpGet]
        [Route("test")]
        public async Task<IHttpActionResult> TestGet()
        {
            try
            {
                var systems = GetUserSystems();
                var becList = "a waw jih lante empiro!";
                //BECLogic.GetBusinessEntitiesContainersForCurrentUser(systems).Select(ec => new
                //{
                //    Id = ec.Id,
                //    System = ec.SystemCode,
                //    Version = ec.Version,
                //    IsActive = ec.IsActive,
                //    EffectiveDate = ec.EffectiveDate,
                //    ExpirationDate = ec.ExpirationDate,
                //    CurrentEditingUser = ec.CurrentEditingUser,
                //    LastStartEditing = ec.LastStartEditing
                //}).ToList();

                return Json(becList);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        protected List<string> GetUserSystems()
        {
            return new List<string>() { "aaa", "bbb" };
            //Roles.GetRolesForUser().Where(u => u.StartsWith("APP_")).Select(u => u.Replace("APP_", "")).ToList<string>();
        }
    }
}
