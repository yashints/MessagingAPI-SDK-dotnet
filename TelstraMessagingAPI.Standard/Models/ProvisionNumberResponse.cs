/*
 * TelstraMessagingAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TelstraMessagingAPI.Standard;
using TelstraMessagingAPI.Standard.Utilities;


namespace TelstraMessagingAPI.Standard.Models
{
    public class ProvisionNumberResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int activeDays;
        private string notifyURL;
        private string destinationAddress;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("activeDays")]
        public int ActiveDays 
        { 
            get 
            {
                return this.activeDays; 
            } 
            set 
            {
                this.activeDays = value;
                onPropertyChanged("ActiveDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notifyURL")]
        public string NotifyURL 
        { 
            get 
            {
                return this.notifyURL; 
            } 
            set 
            {
                this.notifyURL = value;
                onPropertyChanged("NotifyURL");
            }
        }

        /// <summary>
        /// The mobile phone number that was allocated
        /// </summary>
        [JsonProperty("destinationAddress")]
        public string DestinationAddress 
        { 
            get 
            {
                return this.destinationAddress; 
            } 
            set 
            {
                this.destinationAddress = value;
                onPropertyChanged("DestinationAddress");
            }
        }
    }
} 