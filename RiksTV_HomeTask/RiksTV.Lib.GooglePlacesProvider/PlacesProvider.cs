namespace RiksTV.Lib.GooglePlacesProvider
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Threading.Tasks;
    using Configuration;
    using GoogleApi;
    using GoogleApi.Entities.Common;
    using GoogleApi.Entities.Places.Details.Request;
    using GoogleApi.Entities.Places.Details.Response;
    using GoogleApi.Entities.Places.Search.Common.Enums;
    using GoogleApi.Entities.Places.Search.Radar.Request;
    using GoogleApi.Entities.Places.Search.Radar.Response;
    using Helpers;
    using HomeTaskApplication.PlacesProviderInterface;
    using HomeTaskApplication.PlacesProviderInterface.Model;
    using HomeTaskApplication.PlacesProviderInterface.Request;
    using HomeTaskApplication.PlacesProviderInterface.Response;

    public class PlacesProvider : IPlacesProvider
    {
        public async Task<GetPlaceDetailsResponse> GetPlaceDetails(string placeId)
        {
            PlacesDetailsResponse a;

            var response = await GooglePlaces.Details.QueryAsync(PrepareDetailsRequest(placeId));
            return null;
        }

        public async Task<IEnumerable<SearchPlacesResponse>> SearchPlaces(SearchPlacesRequest query)
        {
            PlacesRadarSearchResponse a;

            var response = await GooglePlaces.RadarSearch.QueryAsync(PrepareSearchRequest(query));
            return null;
        }

        public IEnumerable<PlaceType> GetPlaceTypes()
        {
            return
                Enum.GetNames(typeof (SearchPlaceType))
                    .Select(
                        placeTypeValue =>
                            new PlaceType {DisplayName = placeTypeValue.Replace("_", " "), PlaceCode = placeTypeValue})
                    .ToList();
        }

        private static PlacesConfigurationModel GetConfiguration()
        {
            return (PlacesConfigurationModel) ConfigurationManager.GetSection("googlePlacesConfig");
        }

        private PlacesRadarSearchRequest PrepareSearchRequest(SearchPlacesRequest search)
        {
            var request = new PlacesRadarSearchRequest
            {
                Language = "en",
                Radius = search.RadiusKm*1000,
                Types = search.RetriveSearchPlaceTypes()
            };

            AddApiKey(request);

            return request;
        }

        private PlacesDetailsRequest PrepareDetailsRequest(string placeId)
        {
            var request = new PlacesDetailsRequest
            {
                Language = "en",
                PlaceId = placeId
            };

            AddApiKey(request);

            return request;
        }

        private void AddApiKey(BaseRequest request)
        {
            request.Key = GetConfiguration().ApiKey;
        }
    }
}