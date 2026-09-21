using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Model
{
    /// <summary>
    /// Stores the address details for a person.
    /// </summary>

    public class Address
    {
        // Default values
        public const string DEF_STREET_NUM = "No street number provided";
        public const string DEF_STREET_NAME = "No street name provided";
        public const string DEF_SUBURB = "No suburb provided";
        public const string DEF_POSTCODE = "No postcode provided";
        public const string DEF_STATE = "No state provided";

        // Property Assessor Methods
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        /// <summary>
        /// Creates and Address objects using default values.
        /// </summary>

        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        /// <summary>
        /// Creates an Address object using the supplied address details.
        /// </summary>
        /// <param name="streetNum">The street number.</param>
        /// <param name="streetName">The street name.</param>
        /// <param name="suburb">The suburb.</param>
        /// <param name="postcode">The postcode.</param>
        /// <param name="state">The state.</param>
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        ///<summary>
        /// Returns all address information as a string
        ///</summary>
        ///<returns>A string containing all address details.</returns>
        public override string ToString()
        {
            return "street number: " + StreetNum
                + " street name: " + StreetName
                + " suburb: " + Suburb
                + " postcode: " + Postcode
                + " state: " + State;
        }
    }

}
