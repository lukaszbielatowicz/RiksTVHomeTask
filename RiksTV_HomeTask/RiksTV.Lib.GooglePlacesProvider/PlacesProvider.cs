namespace RiksTV.Lib.GooglePlacesProvider
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using GoogleApi.Entities.Places.Details.Request;
    using GoogleApi.Entities.Places.Details.Response;
    using GoogleApi.Entities.Places.Search.Common.Enums;
    using GoogleApi.Entities.Places.Search.Radar.Request;
    using GoogleApi.Entities.Places.Search.Radar.Response;

    using RiksTV.HomeTaskApplication.PlacesProviderInterface;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Model;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Request;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Response;
    using RiksTV.Lib.GooglePlacesProvider.Helpers;

    /// <summary> </summary>
    /// <seealso cref="RiksTV.HomeTaskApplication.PlacesProviderInterface.IPlacesProvider" />
    public class PlacesProvider : IPlacesProvider
    {
        #region Constants

        /// <summary> The km in meters </summary>
        private const int KmInMeters = 1000;

        /// <summary> The language </summary>
        private const string Language = "en";

        #endregion

        #region Public Methods and Operators

        /// <summary> Gets the place details. </summary>
        /// <param name="request"> The request. </param>
        /// <returns> </returns>
        public async Task<GetPlaceDetailsResponse> GetPlaceDetails(GetPlaceDetailsRequest request)
        {
            PlacesDetailsResponse a;

            var response = await GoogleApi.GooglePlaces.Details.QueryAsync(this.PrepareDetailsRequest(request.PlaceId));
            return null;
        }

        /// <summary> Gets the place types. </summary>
        /// <returns> </returns>
        public IEnumerable<PlaceType> GetPlaceTypes()
        {
            return Enum.GetNames(typeof(SearchPlaceType)).Select(placeTypeValue => new PlaceType() { DisplayName = placeTypeValue.Replace("_", " "), PlaceCode = placeTypeValue }).ToList();
        }

        /// <summary> Searches the places. </summary>
        /// <param name="query"> The query. </param>
        /// <returns> </returns>
        public async Task<IEnumerable<SearchPlacesResponse>> SearchPlaces(SearchPlacesRequest query)
        {
            PlacesRadarSearchResponse a;

            var response = await GoogleApi.GooglePlaces.RadarSearch.QueryAsync(this.PrepareSearchRequest(query));
            return null;
        }

        #endregion

        #region Methods

        /// <summary> Gets the configuration. </summary>
        /// <returns> </returns>
        private static Configuration.PlacesConfigurationModel GetConfiguration()
        {
            return (Configuration.PlacesConfigurationModel)System.Configuration.ConfigurationManager.GetSection("googlePlacesConfig");
        }

        /// <summary> Adds the API key. </summary>
        /// <param name="request"> The request. </param>
        private void AddApiKey(GoogleApi.Entities.Common.BaseRequest request)
        {
            request.Key = GetConfiguration().ApiKey;
        }

        /// <summary> Prepares the details request. </summary>
        /// <param name="placeId"> The place identifier. </param>
        /// <returns> </returns>
        private PlacesDetailsRequest PrepareDetailsRequest(string placeId)
        {
            var request = new PlacesDetailsRequest { Language = Language, PlaceId = placeId };

            this.AddApiKey(request);

            return request;
        }

        /// <summary> Prepares the search request. </summary>
        /// <param name="search"> The search. </param>
        /// <returns> </returns>
        private PlacesRadarSearchRequest PrepareSearchRequest(SearchPlacesRequest search)
        {
            var request = new PlacesRadarSearchRequest { Language = Language, Radius = search.RadiusKm * KmInMeters, Types = search.RetriveSearchPlaceTypes() };

            this.AddApiKey(request);

            return request;
        }

        #endregion
    }
}