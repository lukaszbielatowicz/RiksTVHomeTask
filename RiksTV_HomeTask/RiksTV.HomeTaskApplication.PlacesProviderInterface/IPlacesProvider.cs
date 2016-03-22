namespace RiksTV.HomeTaskApplication.PlacesProviderInterface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Request;
    using Response;

    /// <summary>
    /// 
    /// </summary>
    public interface IPlacesProvider
    {
        /// <summary>
        /// Gets the place details.
        /// </summary>
        /// <param name="identNo">The ident no.</param>
        /// <returns></returns>
        Task<GetPlaceDetailsResponse> GetPlaceDetails(string identNo);

        /// <summary>
        /// Searches the places.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        Task<IEnumerable<SearchPlacesResponse>> SearchPlaces(SearchPlacesRequest query);

        /// <summary>
        /// Gets the place types.
        /// </summary>
        /// <returns></returns>
        IEnumerable<PlaceType> GetPlaceTypes();
    }
}