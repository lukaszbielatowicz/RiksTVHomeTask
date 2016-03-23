namespace RiksTV.HomeTaskApplication.Controllers
{
    using System.Web.Mvc;

    /// <summary> </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class TemplatesController : Controller
    {
        #region Public Methods and Operators

        /// <summary> Mains the page. </summary>
        /// <returns> </returns>
        public ActionResult MainPage()
        {
            return this.PartialView();
        }

        /// <summary> Places the details. </summary>
        /// <returns> </returns>
        public ActionResult PlaceDetails()
        {
            return this.PartialView();
        }

        #endregion
    }
}