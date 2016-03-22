namespace RiksTV.Lib.GooglePlacesProvider.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GoogleApi.Entities.Places.Search.Common.Enums;
    using HomeTaskApplication.PlacesProviderInterface.Model;
    using HomeTaskApplication.PlacesProviderInterface.Request;

    /// <summary>
    /// </summary>
    public static class PlaceTypeConvertHelper
    {
        /// <summary>
        ///     Converts the specified place type.
        /// </summary>
        /// <param name="placeType">Type of the place.</param>
        /// <returns></returns>
        public static SearchPlaceType? Convert(this string placeType)
        {
            SearchPlaceType result;
            return Enum.TryParse(placeType, out result) ? (SearchPlaceType?) result : null;
        }

        /// <summary>
        ///     Retrives the search place types.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public static ICollection<SearchPlaceType> RetriveSearchPlaceTypes(this SearchPlacesRequest request)
        {
            return
                request?.PlaceCode?.Select(pc => pc.Convert()).Where(pc => pc.HasValue).Select(pc => pc.Value).ToList() ??
                new List<SearchPlaceType>();
        }

        /// <summary>
        ///     Converts the specified search place type.
        /// </summary>
        /// <param name="searchPlaceType">Type of the search place.</param>
        /// <returns></returns>
        public static PlaceType Convert(this SearchPlaceType searchPlaceType)
        {
            var result = new PlaceType {PlaceCode = searchPlaceType.ToString()};
            result.DisplayName = result.PlaceCode.Replace("_", " ");
            return result;
        }
    }
}