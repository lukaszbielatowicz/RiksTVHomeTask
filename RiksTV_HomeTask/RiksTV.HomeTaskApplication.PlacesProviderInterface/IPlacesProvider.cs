namespace RiksTV.HomeTaskApplication.PlacesProviderInterface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Model;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Request;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Response;

    /// <summary> </summary>
    public interface IPlacesProvider
    {
        #region Public Methods and Operators

        /// <summary> Gets the place details. </summary>
        /// <param name="request"> The request. </param>
        /// <returns> </returns>
        Task<GetPlaceDetailsResponse> GetPlaceDetails(GetPlaceDetailsRequest request);

        /// <summary> Gets the place types. </summary>
        /// <returns> </returns>
        IEnumerable<PlaceType> GetPlaceTypes();

        /// <summary> Searches the places. </summary>
        /// <param name="query"> The query. </param>
        /// <returns> </returns>
        Task<IEnumerable<SearchPlacesResponse>> SearchPlaces(SearchPlacesRequest query);

        #endregion
    }
}