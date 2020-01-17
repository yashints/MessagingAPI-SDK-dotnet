/* 
 * Telstra Messaging API
 *
 * The API specification for Telstra Messaging API
 *
 * The version of the OpenAPI document: 2.2.9
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Telstra.Messaging.Client.OpenAPIDateConverter;

namespace Telstra.Messaging.Model
{
    /// <summary>
    /// ProvisionNumberResponse
    /// </summary>
    [DataContract]
    public partial class ProvisionNumberResponse :  IEquatable<ProvisionNumberResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionNumberResponse" /> class.
        /// </summary>
        /// <param name="destinationAddress">The mobile phone number that was allocated.</param>
        /// <param name="expiryDate">Free Trial apps can only add activeDays for their provisioned number every 30 days. This is in Unix time format..</param>
        public ProvisionNumberResponse(string destinationAddress = default(string), decimal expiryDate = default(decimal))
        {
            this.DestinationAddress = destinationAddress;
            this.ExpiryDate = expiryDate;
        }
        
        /// <summary>
        /// The mobile phone number that was allocated
        /// </summary>
        /// <value>The mobile phone number that was allocated</value>
        [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Free Trial apps can only add activeDays for their provisioned number every 30 days. This is in Unix time format.
        /// </summary>
        /// <value>Free Trial apps can only add activeDays for their provisioned number every 30 days. This is in Unix time format.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public decimal ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisionNumberResponse {\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as ProvisionNumberResponse);
        }

        /// <summary>
        /// Returns true if ProvisionNumberResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvisionNumberResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvisionNumberResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationAddress == input.DestinationAddress ||
                    (this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(input.DestinationAddress))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    this.ExpiryDate.Equals(input.ExpiryDate)
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
                if (this.DestinationAddress != null)
                    hashCode = hashCode * 59 + this.DestinationAddress.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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