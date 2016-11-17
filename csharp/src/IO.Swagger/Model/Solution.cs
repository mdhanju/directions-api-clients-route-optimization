/* 
 * Route Optimization API
 *
 * Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Solution
    /// </summary>
    [DataContract]
    public partial class Solution :  IEquatable<Solution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Solution" /> class.
        /// </summary>
        /// <param name="Costs">overall costs of solution.</param>
        /// <param name="Distance">overall travel distance in meters.</param>
        /// <param name="Time">overall transport time in ms.</param>
        /// <param name="TransportTime">overall transport time in ms.</param>
        /// <param name="MaxOperationTime">operation time of the longest route in ms.</param>
        /// <param name="WaitingTime">total waiting time in ms.</param>
        /// <param name="NoVehicles">number of employed vehicles.</param>
        /// <param name="NoUnassigned">number of jobs that could not be assigned to final solution.</param>
        /// <param name="Routes">An array of routes.</param>
        /// <param name="Unassigned">Unassigned.</param>
        public Solution(int? Costs = null, int? Distance = null, long? Time = null, long? TransportTime = null, long? MaxOperationTime = null, long? WaitingTime = null, int? NoVehicles = null, int? NoUnassigned = null, List<Route> Routes = null, SolutionUnassigned Unassigned = null)
        {
            this.Costs = Costs;
            this.Distance = Distance;
            this.Time = Time;
            this.TransportTime = TransportTime;
            this.MaxOperationTime = MaxOperationTime;
            this.WaitingTime = WaitingTime;
            this.NoVehicles = NoVehicles;
            this.NoUnassigned = NoUnassigned;
            this.Routes = Routes;
            this.Unassigned = Unassigned;
        }
        
        /// <summary>
        /// overall costs of solution
        /// </summary>
        /// <value>overall costs of solution</value>
        [DataMember(Name="costs", EmitDefaultValue=false)]
        public int? Costs { get; set; }
        /// <summary>
        /// overall travel distance in meters
        /// </summary>
        /// <value>overall travel distance in meters</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }
        /// <summary>
        /// overall transport time in ms
        /// </summary>
        /// <value>overall transport time in ms</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }
        /// <summary>
        /// overall transport time in ms
        /// </summary>
        /// <value>overall transport time in ms</value>
        [DataMember(Name="transport_time", EmitDefaultValue=false)]
        public long? TransportTime { get; set; }
        /// <summary>
        /// operation time of the longest route in ms
        /// </summary>
        /// <value>operation time of the longest route in ms</value>
        [DataMember(Name="max_operation_time", EmitDefaultValue=false)]
        public long? MaxOperationTime { get; set; }
        /// <summary>
        /// total waiting time in ms
        /// </summary>
        /// <value>total waiting time in ms</value>
        [DataMember(Name="waiting_time", EmitDefaultValue=false)]
        public long? WaitingTime { get; set; }
        /// <summary>
        /// number of employed vehicles
        /// </summary>
        /// <value>number of employed vehicles</value>
        [DataMember(Name="no_vehicles", EmitDefaultValue=false)]
        public int? NoVehicles { get; set; }
        /// <summary>
        /// number of jobs that could not be assigned to final solution
        /// </summary>
        /// <value>number of jobs that could not be assigned to final solution</value>
        [DataMember(Name="no_unassigned", EmitDefaultValue=false)]
        public int? NoUnassigned { get; set; }
        /// <summary>
        /// An array of routes
        /// </summary>
        /// <value>An array of routes</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<Route> Routes { get; set; }
        /// <summary>
        /// Gets or Sets Unassigned
        /// </summary>
        [DataMember(Name="unassigned", EmitDefaultValue=false)]
        public SolutionUnassigned Unassigned { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Solution {\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TransportTime: ").Append(TransportTime).Append("\n");
            sb.Append("  MaxOperationTime: ").Append(MaxOperationTime).Append("\n");
            sb.Append("  WaitingTime: ").Append(WaitingTime).Append("\n");
            sb.Append("  NoVehicles: ").Append(NoVehicles).Append("\n");
            sb.Append("  NoUnassigned: ").Append(NoUnassigned).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Unassigned: ").Append(Unassigned).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Solution);
        }

        /// <summary>
        /// Returns true if Solution instances are equal
        /// </summary>
        /// <param name="other">Instance of Solution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Solution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Costs == other.Costs ||
                    this.Costs != null &&
                    this.Costs.Equals(other.Costs)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.TransportTime == other.TransportTime ||
                    this.TransportTime != null &&
                    this.TransportTime.Equals(other.TransportTime)
                ) && 
                (
                    this.MaxOperationTime == other.MaxOperationTime ||
                    this.MaxOperationTime != null &&
                    this.MaxOperationTime.Equals(other.MaxOperationTime)
                ) && 
                (
                    this.WaitingTime == other.WaitingTime ||
                    this.WaitingTime != null &&
                    this.WaitingTime.Equals(other.WaitingTime)
                ) && 
                (
                    this.NoVehicles == other.NoVehicles ||
                    this.NoVehicles != null &&
                    this.NoVehicles.Equals(other.NoVehicles)
                ) && 
                (
                    this.NoUnassigned == other.NoUnassigned ||
                    this.NoUnassigned != null &&
                    this.NoUnassigned.Equals(other.NoUnassigned)
                ) && 
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(other.Routes)
                ) && 
                (
                    this.Unassigned == other.Unassigned ||
                    this.Unassigned != null &&
                    this.Unassigned.Equals(other.Unassigned)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Costs != null)
                    hash = hash * 59 + this.Costs.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.TransportTime != null)
                    hash = hash * 59 + this.TransportTime.GetHashCode();
                if (this.MaxOperationTime != null)
                    hash = hash * 59 + this.MaxOperationTime.GetHashCode();
                if (this.WaitingTime != null)
                    hash = hash * 59 + this.WaitingTime.GetHashCode();
                if (this.NoVehicles != null)
                    hash = hash * 59 + this.NoVehicles.GetHashCode();
                if (this.NoUnassigned != null)
                    hash = hash * 59 + this.NoUnassigned.GetHashCode();
                if (this.Routes != null)
                    hash = hash * 59 + this.Routes.GetHashCode();
                if (this.Unassigned != null)
                    hash = hash * 59 + this.Unassigned.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
