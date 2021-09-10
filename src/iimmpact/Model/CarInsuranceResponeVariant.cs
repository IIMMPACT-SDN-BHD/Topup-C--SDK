/* 
 * IIMMPACT API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2020-09-14T13:01:14Z
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
using SwaggerDateConverter = iimmpact.Client.SwaggerDateConverter;

namespace iimmpact.Model
{
    /// <summary>
    /// CarInsuranceResponeVariant
    /// </summary>
    [DataContract]
    public partial class CarInsuranceResponeVariant :  IEquatable<CarInsuranceResponeVariant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarInsuranceResponeVariant" /> class.
        /// </summary>
        /// <param name="nvic">nvic.</param>
        /// <param name="desc">desc.</param>
        /// <param name="marketValue">marketValue.</param>
        /// <param name="cc">cc.</param>
        /// <param name="fullmodelDesc">fullmodelDesc.</param>
        public CarInsuranceResponeVariant(string nvic = default(string), string desc = default(string), string marketValue = default(string), string cc = default(string), string fullmodelDesc = default(string))
        {
            this.Nvic = nvic;
            this.Desc = desc;
            this.MarketValue = marketValue;
            this.Cc = cc;
            this.FullmodelDesc = fullmodelDesc;
        }
        
        /// <summary>
        /// Gets or Sets Nvic
        /// </summary>
        [DataMember(Name="nvic", EmitDefaultValue=false)]
        public string Nvic { get; set; }

        /// <summary>
        /// Gets or Sets Desc
        /// </summary>
        [DataMember(Name="desc", EmitDefaultValue=false)]
        public string Desc { get; set; }

        /// <summary>
        /// Gets or Sets MarketValue
        /// </summary>
        [DataMember(Name="marketValue", EmitDefaultValue=false)]
        public string MarketValue { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public string Cc { get; set; }

        /// <summary>
        /// Gets or Sets FullmodelDesc
        /// </summary>
        [DataMember(Name="fullmodelDesc", EmitDefaultValue=false)]
        public string FullmodelDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarInsuranceResponeVariant {\n");
            sb.Append("  Nvic: ").Append(Nvic).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  FullmodelDesc: ").Append(FullmodelDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CarInsuranceResponeVariant);
        }

        /// <summary>
        /// Returns true if CarInsuranceResponeVariant instances are equal
        /// </summary>
        /// <param name="input">Instance of CarInsuranceResponeVariant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarInsuranceResponeVariant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nvic == input.Nvic ||
                    (this.Nvic != null &&
                    this.Nvic.Equals(input.Nvic))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.MarketValue == input.MarketValue ||
                    (this.MarketValue != null &&
                    this.MarketValue.Equals(input.MarketValue))
                ) && 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.FullmodelDesc == input.FullmodelDesc ||
                    (this.FullmodelDesc != null &&
                    this.FullmodelDesc.Equals(input.FullmodelDesc))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Nvic != null)
                    hashCode = hashCode * 59 + this.Nvic.GetHashCode();
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.MarketValue != null)
                    hashCode = hashCode * 59 + this.MarketValue.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.FullmodelDesc != null)
                    hashCode = hashCode * 59 + this.FullmodelDesc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
