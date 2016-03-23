namespace RiksTV.HomeTaskApplication.PlacesProviderInterface.Request
{
    using System.Collections.Generic;

    public class SearchPlacesRequest
    {
        public int RadiusKm { get; set; }

        public IEnumerable<string> PlaceCode { get; set; }

        public IEnumerable<string> Keywords { get; set; }
    }
}
