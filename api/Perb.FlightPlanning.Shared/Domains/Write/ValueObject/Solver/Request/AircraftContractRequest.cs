// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using Newtonsoft.Json;

namespace Perb.FlightPlanning.Shared.Domains.Write.ValueObject.Solver.Request
{
    /// <summary>
    /// AircraftContract
    /// </summary>
    public class AircraftContractRequest
    {
     

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "considerCrewRegulations")]
        public bool? ConsiderCrewRegulations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceTimeInMinutes")]
        public int? MaintenanceTimeInMinutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeByDayInMinutes")]
        public int? TimeByDayInMinutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSeats")]
        public int? TotalSeats { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

    }
}
