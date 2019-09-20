// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MicrosoftNewsAPI.SDK.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MsnTagsDataModelTagEntityLibLocation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibLocation class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibLocation class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibLocation(string countryCode = default(string), string subdivision = default(string), string city = default(string), double? latitude = default(double?), double? longitude = default(double?), int? radiusMeters = default(int?))
        {
            CountryCode = countryCode;
            Subdivision = subdivision;
            City = city;
            Latitude = latitude;
            Longitude = longitude;
            RadiusMeters = radiusMeters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subdivision")]
        public string Subdivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "radiusMeters")]
        public int? RadiusMeters { get; set; }

    }
}
