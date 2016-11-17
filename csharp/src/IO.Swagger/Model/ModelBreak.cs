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
    /// ModelBreak
    /// </summary>
    [DataContract]
    public partial class ModelBreak :  IEquatable<ModelBreak>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBreak" /> class.
        /// </summary>
        /// <param name="Earliest">earliest start of break.</param>
        /// <param name="Latest">latest start of break.</param>
        /// <param name="Duration">duration of break.</param>
        /// <param name="MaxDrivingTime">max driving time without break.</param>
        /// <param name="InitialDrivingTime">initial driving time, i.e. the time your driver has already spent for driving.</param>
        /// <param name="PossibleSplit">array of splits.</param>
        public ModelBreak(long? Earliest = null, long? Latest = null, long? Duration = null, long? MaxDrivingTime = null, long? InitialDrivingTime = null, List<long?> PossibleSplit = null)
        {
            this.Earliest = Earliest;
            this.Latest = Latest;
            this.Duration = Duration;
            this.MaxDrivingTime = MaxDrivingTime;
            this.InitialDrivingTime = InitialDrivingTime;
            this.PossibleSplit = PossibleSplit;
        }
        
        /// <summary>
        /// earliest start of break
        /// </summary>
        /// <value>earliest start of break</value>
        [DataMember(Name="earliest", EmitDefaultValue=false)]
        public long? Earliest { get; set; }
        /// <summary>
        /// latest start of break
        /// </summary>
        /// <value>latest start of break</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        public long? Latest { get; set; }
        /// <summary>
        /// duration of break
        /// </summary>
        /// <value>duration of break</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }
        /// <summary>
        /// max driving time without break
        /// </summary>
        /// <value>max driving time without break</value>
        [DataMember(Name="max_driving_time", EmitDefaultValue=false)]
        public long? MaxDrivingTime { get; set; }
        /// <summary>
        /// initial driving time, i.e. the time your driver has already spent for driving
        /// </summary>
        /// <value>initial driving time, i.e. the time your driver has already spent for driving</value>
        [DataMember(Name="initial_driving_time", EmitDefaultValue=false)]
        public long? InitialDrivingTime { get; set; }
        /// <summary>
        /// array of splits
        /// </summary>
        /// <value>array of splits</value>
        [DataMember(Name="possible_split", EmitDefaultValue=false)]
        public List<long?> PossibleSplit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelBreak {\n");
            sb.Append("  Earliest: ").Append(Earliest).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  MaxDrivingTime: ").Append(MaxDrivingTime).Append("\n");
            sb.Append("  InitialDrivingTime: ").Append(InitialDrivingTime).Append("\n");
            sb.Append("  PossibleSplit: ").Append(PossibleSplit).Append("\n");
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
            return this.Equals(obj as ModelBreak);
        }

        /// <summary>
        /// Returns true if ModelBreak instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelBreak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelBreak other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Earliest == other.Earliest ||
                    this.Earliest != null &&
                    this.Earliest.Equals(other.Earliest)
                ) && 
                (
                    this.Latest == other.Latest ||
                    this.Latest != null &&
                    this.Latest.Equals(other.Latest)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.MaxDrivingTime == other.MaxDrivingTime ||
                    this.MaxDrivingTime != null &&
                    this.MaxDrivingTime.Equals(other.MaxDrivingTime)
                ) && 
                (
                    this.InitialDrivingTime == other.InitialDrivingTime ||
                    this.InitialDrivingTime != null &&
                    this.InitialDrivingTime.Equals(other.InitialDrivingTime)
                ) && 
                (
                    this.PossibleSplit == other.PossibleSplit ||
                    this.PossibleSplit != null &&
                    this.PossibleSplit.SequenceEqual(other.PossibleSplit)
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
                if (this.Earliest != null)
                    hash = hash * 59 + this.Earliest.GetHashCode();
                if (this.Latest != null)
                    hash = hash * 59 + this.Latest.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.MaxDrivingTime != null)
                    hash = hash * 59 + this.MaxDrivingTime.GetHashCode();
                if (this.InitialDrivingTime != null)
                    hash = hash * 59 + this.InitialDrivingTime.GetHashCode();
                if (this.PossibleSplit != null)
                    hash = hash * 59 + this.PossibleSplit.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
