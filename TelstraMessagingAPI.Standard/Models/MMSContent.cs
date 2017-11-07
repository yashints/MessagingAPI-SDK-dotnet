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
    public class MMSContent : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private string filename;
        private string payload;

        /// <summary>
        /// The following types are supported audio/amr 	audio/aac 	audio/mp3
        /// 	audio/mpeg3 	audio/mpeg 	audio/mpg 	audio/wav 	audio/3gpp 	audio/mp4
        /// 	image/gif 	image/jpeg 	image/jpg 	image/png 	image/bmp 	video/mpeg4
        /// 	video/mp4 	video/mpeg 	video/3gpp 	video/3gp 	video/h263 	text/plain
        /// 	text/x-vCard 	text/x-vCalendar
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The file name to be associated with the content. Some devices
        /// will display this file name with a placeholder for the content.
        /// </summary>
        [JsonProperty("filename")]
        public string Filename 
        { 
            get 
            {
                return this.filename; 
            } 
            set 
            {
                this.filename = value;
                onPropertyChanged("Filename");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payload")]
        public string Payload 
        { 
            get 
            {
                return this.payload; 
            } 
            set 
            {
                this.payload = value;
                onPropertyChanged("Payload");
            }
        }
    }
} 