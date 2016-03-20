using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleApi.Entities.Places.Details.Request;
using GoogleApi.Entities.Places.Search.Common.Enums;
using GoogleApi.Entities.Places.Search.Radar.Request;
using RiksTV.HomeTaskApplication.PlacesProviderInterface;

namespace RiksTV.Lib.GooglePlacesProvider
{
    public class PlacesProvider : IPlacesProvider {

        private static Configuration.PlacesConfigurationModel GetConfiguration()
        {
            return (Configuration.PlacesConfigurationModel) System.Configuration.ConfigurationManager.GetSection("googlePlacesConfig");
        }

        private PlacesRadarSearchRequest PrepareSearchRequest()
        {
            var request = new PlacesRadarSearchRequest();
            request.Language = "en";
            request.Radius = 2000;
            request.Types = new List<SearchPlaceType>() ;
            AddApiKey(request);
            return request;
        }

        private PlacesDetailsRequest PrepareDetailsRequest()
        {
            var request = new PlacesDetailsRequest();
            request.Language = "en";
            AddApiKey(request);
            return request;
        }

        private void AddApiKey(GoogleApi.Entities.Common.BaseRequest request)
        {
            request.Key = GetConfiguration().ApiKey;
        }

    }
}
