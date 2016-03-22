namespace RiksTV.HomeTaskApplication.PlacesProviderInterface.Request
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class SearchPlacesRequest
    {
        public int RadiusKm { get; set; }

        public IEnumerable<string> PlaceCode { get; set; }

        public IEnumerable<string> Keywords { get; set; }
    }
}