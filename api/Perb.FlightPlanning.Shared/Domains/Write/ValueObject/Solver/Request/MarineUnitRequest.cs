// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Perb.FlightPlanning.Shared.Domains.Write.ValueObject.Solver.Request
{
    /// <summary>
    /// MarineUnit
    /// </summary>
    public class MarineUnitRequest
    {
       

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "demand")]
        public int? Demand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flightPreferenceList")]
        public IList<FlightPreferenceRequest> FlightPreferenceList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxAircraftDimension")]
        public int? MaxAircraftDimension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxAircraftWeight")]
        public int? MaxAircraftWeight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeByAircraftType")]
        public IList<TimeByAircraftType> TimeByAircraftType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toBeAnnounced")]
        public bool? ToBeAnnounced { get; set; }

    }

    public class TimeByAircraftType
    {
        [JsonProperty(PropertyName = "timeInMinutes")]
        public int TimeInMinutes { get; set; }
        
        [JsonProperty(PropertyName = "aircraftType")]
        public string AircraftType { get; set; }
    }
}