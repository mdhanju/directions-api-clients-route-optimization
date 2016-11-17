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
    /// Objective
    /// </summary>
    [DataContract]
    public partial class Objective :  IEquatable<Objective>, IValidatableObject
    {
        /// <summary>
        /// type of objective function, i.e. min or min-max 
        /// </summary>
        /// <value>type of objective function, i.e. min or min-max </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Minmax for "min-max"
            /// </summary>
            [EnumMember(Value = "min-max")]
            Minmax
        }

        /// <summary>
        /// objective function value
        /// </summary>
        /// <value>objective function value</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueEnum
        {
            
            /// <summary>
            /// Enum Completiontime for "completion_time"
            /// </summary>
            [EnumMember(Value = "completion_time")]
            Completiontime,
            
            /// <summary>
            /// Enum Transporttime for "transport_time"
            /// </summary>
            [EnumMember(Value = "transport_time")]
            Transporttime,
            
            /// <summary>
            /// Enum Vehicles for "vehicles"
            /// </summary>
            [EnumMember(Value = "vehicles")]
            Vehicles
        }

        /// <summary>
        /// type of objective function, i.e. min or min-max 
        /// </summary>
        /// <value>type of objective function, i.e. min or min-max </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// objective function value
        /// </summary>
        /// <value>objective function value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public ValueEnum? Value { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Objective" /> class.
        /// </summary>
        /// <param name="Type">type of objective function, i.e. min or min-max .</param>
        /// <param name="Value">objective function value.</param>
        public Objective(TypeEnum? Type = null, ValueEnum? Value = null)
        {
            this.Type = Type;
            this.Value = Value;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Objective {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as Objective);
        }

        /// <summary>
        /// Returns true if Objective instances are equal
        /// </summary>
        /// <param name="other">Instance of Objective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Objective other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
