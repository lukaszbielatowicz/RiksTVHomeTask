using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiksTV.Lib.GooglePlacesProvider.Helpers
{
    using GoogleApi.Entities.Places.Search.Common.Enums;

    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Model;
    using RiksTV.HomeTaskApplication.PlacesProviderInterface.Request;

    public static class PlaceTypeConvertHelper
    {
        public static SearchPlaceType? Convert(this string placeType)
        {
            SearchPlaceType result;
            return Enum.TryParse(placeType, out result) ? (SearchPlaceType?)result : null;
        }

        public static ICollection<SearchPlaceType> RetriveSearchPlaceTypes(this SearchPlacesRequest request)
        {
            return request?.PlaceCode?.Select(pc => pc.Convert()).Where(pc => pc.HasValue).Select(pc => pc.Value).ToList() ?? new List<SearchPlaceType>();
        }

        public static PlaceType Convert(this SearchPlaceType searchPlaceType)
        {
            var result = new PlaceType { PlaceCode = searchPlaceType.ToString() };
            result.DisplayName = result.PlaceCode.Replace("_", " ");
            return result;
        }

    }
}
