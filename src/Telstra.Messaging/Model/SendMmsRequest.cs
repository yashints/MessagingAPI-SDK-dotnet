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
    /// SendMmsRequest
    /// </summary>
    [DataContract]
    public partial class SendMmsRequest :  IEquatable<SendMmsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMmsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendMmsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMmsRequest" /> class.
        /// </summary>
        /// <param name="to">This is the destination address. Can be an array of strings if sending to multiple numbers: \&quot;to\&quot;:[\&quot;+61412345678\&quot;, \&quot;+61418765432\&quot;]  (required).</param>
        /// <param name="from">This will be the source address that will be displayed on the receiving device. You can set an Alphanumeric sender ID of up to 11 characters that the MMS was sent from. Phone numbers in the &#x60;from&#x60; attribute will be blocked (400-error) to prevent number spoofing.  Most standard ASCII characters are accepted in the alphanumeric &#x60;from&#x60; attribute, however there are some limitations. The following limitations and characters are allowed in the alphanumeric &#x60;from&#x60; attribute; any alphabetic character (e.g. &#x60;abc&#x60;), any number mixed with alphabetic characters (e.g. &#x60;123abc&#x60;), uppercase and lowercase characters (e.g. &#x60;aBc&#x60;), any of the following special characters mixed with alphabetic characters are allowed; &#x60;~!@#$%^&amp;*()~_~+-&#x3D;{}|[];&#39;?,./&#x60; (e.g. &#x60;abc~!@&#x60;), any combination of lowercase, uppercase, numeric or allowed special characters (e.g. &#x60;abc@#123DE&#x60;). All other characters, including spaces and extended ASCII characters, are not allowed (e.g. &#x60;&lt;&gt;:\&quot;\\&#x60;).  If attribute is not present, the service will use the mobile number associated with the application (in E.164 format).  If &#x60;replyRequest&#x60; is set to true, this field should not be present.  This feature is only available on Telstra Account paid plans, not through Free Trials or credit card paid plans.   *Please note:*  *- Alphanumeric sender ID works for domestic, i.e. Australian, destinations only.*  *- When Alphanumeric sender ID is used in sending MMS, Delivery Reports will NOT be returned.* .</param>
        /// <param name="subject">The subject that will be used in an MMS message. Subject is limited to maximum of 64 characters.  Some special characters need to be encoded if used in the &#x60;subject&#x60; field (e.g. &amp;amp;amp; for &amp; and &amp;amp;lt; for &lt;). .</param>
        /// <param name="replyRequest">If set to true, the reply message functionality will be implemented. The &#x60;from&#x60; field should not be present. .</param>
        /// <param name="notifyURL">Contains a URL that will be called once your message has been processed. The status may be delivered, expired, deleted, etc. Please refer to the Delivery Status section for more information.  If you are using a domain URL you must include the forward slash at the end of the URL (e.g. http://www.example.com/). .</param>
        /// <param name="mMSContent">An array of content that will be sent in an MMS message. If this array is present it will cause the &#x60;body&#x60; element to be ignored, and the message will be sent as an MMS.  (required).</param>
        public SendMmsRequest(string to = default(string), string from = default(string), string subject = default(string), bool replyRequest = default(bool), string notifyURL = default(string), List<MMSContent> mMSContent = default(List<MMSContent>))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for SendMmsRequest and cannot be null");
            }
            else
            {
                this.To = to;
            }

            // to ensure "mMSContent" is required (not null)
            if (mMSContent == null)
            {
                throw new InvalidDataException("mMSContent is a required property for SendMmsRequest and cannot be null");
            }
            else
            {
                this.MMSContent = mMSContent;
            }

            this.From = from;
            this.Subject = subject;
            this.ReplyRequest = replyRequest;
            this.NotifyURL = notifyURL;
        }
        
        /// <summary>
        /// This is the destination address. Can be an array of strings if sending to multiple numbers: \&quot;to\&quot;:[\&quot;+61412345678\&quot;, \&quot;+61418765432\&quot;] 
        /// </summary>
        /// <value>This is the destination address. Can be an array of strings if sending to multiple numbers: \&quot;to\&quot;:[\&quot;+61412345678\&quot;, \&quot;+61418765432\&quot;] </value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// This will be the source address that will be displayed on the receiving device. You can set an Alphanumeric sender ID of up to 11 characters that the MMS was sent from. Phone numbers in the &#x60;from&#x60; attribute will be blocked (400-error) to prevent number spoofing.  Most standard ASCII characters are accepted in the alphanumeric &#x60;from&#x60; attribute, however there are some limitations. The following limitations and characters are allowed in the alphanumeric &#x60;from&#x60; attribute; any alphabetic character (e.g. &#x60;abc&#x60;), any number mixed with alphabetic characters (e.g. &#x60;123abc&#x60;), uppercase and lowercase characters (e.g. &#x60;aBc&#x60;), any of the following special characters mixed with alphabetic characters are allowed; &#x60;~!@#$%^&amp;*()~_~+-&#x3D;{}|[];&#39;?,./&#x60; (e.g. &#x60;abc~!@&#x60;), any combination of lowercase, uppercase, numeric or allowed special characters (e.g. &#x60;abc@#123DE&#x60;). All other characters, including spaces and extended ASCII characters, are not allowed (e.g. &#x60;&lt;&gt;:\&quot;\\&#x60;).  If attribute is not present, the service will use the mobile number associated with the application (in E.164 format).  If &#x60;replyRequest&#x60; is set to true, this field should not be present.  This feature is only available on Telstra Account paid plans, not through Free Trials or credit card paid plans.   *Please note:*  *- Alphanumeric sender ID works for domestic, i.e. Australian, destinations only.*  *- When Alphanumeric sender ID is used in sending MMS, Delivery Reports will NOT be returned.* 
        /// </summary>
        /// <value>This will be the source address that will be displayed on the receiving device. You can set an Alphanumeric sender ID of up to 11 characters that the MMS was sent from. Phone numbers in the &#x60;from&#x60; attribute will be blocked (400-error) to prevent number spoofing.  Most standard ASCII characters are accepted in the alphanumeric &#x60;from&#x60; attribute, however there are some limitations. The following limitations and characters are allowed in the alphanumeric &#x60;from&#x60; attribute; any alphabetic character (e.g. &#x60;abc&#x60;), any number mixed with alphabetic characters (e.g. &#x60;123abc&#x60;), uppercase and lowercase characters (e.g. &#x60;aBc&#x60;), any of the following special characters mixed with alphabetic characters are allowed; &#x60;~!@#$%^&amp;*()~_~+-&#x3D;{}|[];&#39;?,./&#x60; (e.g. &#x60;abc~!@&#x60;), any combination of lowercase, uppercase, numeric or allowed special characters (e.g. &#x60;abc@#123DE&#x60;). All other characters, including spaces and extended ASCII characters, are not allowed (e.g. &#x60;&lt;&gt;:\&quot;\\&#x60;).  If attribute is not present, the service will use the mobile number associated with the application (in E.164 format).  If &#x60;replyRequest&#x60; is set to true, this field should not be present.  This feature is only available on Telstra Account paid plans, not through Free Trials or credit card paid plans.   *Please note:*  *- Alphanumeric sender ID works for domestic, i.e. Australian, destinations only.*  *- When Alphanumeric sender ID is used in sending MMS, Delivery Reports will NOT be returned.* </value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// The subject that will be used in an MMS message. Subject is limited to maximum of 64 characters.  Some special characters need to be encoded if used in the &#x60;subject&#x60; field (e.g. &amp;amp;amp; for &amp; and &amp;amp;lt; for &lt;). 
        /// </summary>
        /// <value>The subject that will be used in an MMS message. Subject is limited to maximum of 64 characters.  Some special characters need to be encoded if used in the &#x60;subject&#x60; field (e.g. &amp;amp;amp; for &amp; and &amp;amp;lt; for &lt;). </value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// If set to true, the reply message functionality will be implemented. The &#x60;from&#x60; field should not be present. 
        /// </summary>
        /// <value>If set to true, the reply message functionality will be implemented. The &#x60;from&#x60; field should not be present. </value>
        [DataMember(Name="replyRequest", EmitDefaultValue=false)]
        public bool ReplyRequest { get; set; }

        /// <summary>
        /// Contains a URL that will be called once your message has been processed. The status may be delivered, expired, deleted, etc. Please refer to the Delivery Status section for more information.  If you are using a domain URL you must include the forward slash at the end of the URL (e.g. http://www.example.com/). 
        /// </summary>
        /// <value>Contains a URL that will be called once your message has been processed. The status may be delivered, expired, deleted, etc. Please refer to the Delivery Status section for more information.  If you are using a domain URL you must include the forward slash at the end of the URL (e.g. http://www.example.com/). </value>
        [DataMember(Name="notifyURL", EmitDefaultValue=false)]
        public string NotifyURL { get; set; }

        /// <summary>
        /// An array of content that will be sent in an MMS message. If this array is present it will cause the &#x60;body&#x60; element to be ignored, and the message will be sent as an MMS. 
        /// </summary>
        /// <value>An array of content that will be sent in an MMS message. If this array is present it will cause the &#x60;body&#x60; element to be ignored, and the message will be sent as an MMS. </value>
        [DataMember(Name="MMSContent", EmitDefaultValue=false)]
        public List<MMSContent> MMSContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMmsRequest {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ReplyRequest: ").Append(ReplyRequest).Append("\n");
            sb.Append("  NotifyURL: ").Append(NotifyURL).Append("\n");
            sb.Append("  MMSContent: ").Append(MMSContent).Append("\n");
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
            return this.Equals(input as SendMmsRequest);
        }

        /// <summary>
        /// Returns true if SendMmsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMmsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMmsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.ReplyRequest == input.ReplyRequest ||
                    this.ReplyRequest.Equals(input.ReplyRequest)
                ) && 
                (
                    this.NotifyURL == input.NotifyURL ||
                    (this.NotifyURL != null &&
                    this.NotifyURL.Equals(input.NotifyURL))
                ) && 
                (
                    this.MMSContent == input.MMSContent ||
                    this.MMSContent != null &&
                    input.MMSContent != null &&
                    this.MMSContent.SequenceEqual(input.MMSContent)
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.ReplyRequest.GetHashCode();
                if (this.NotifyURL != null)
                    hashCode = hashCode * 59 + this.NotifyURL.GetHashCode();
                if (this.MMSContent != null)
                    hashCode = hashCode * 59 + this.MMSContent.GetHashCode();
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