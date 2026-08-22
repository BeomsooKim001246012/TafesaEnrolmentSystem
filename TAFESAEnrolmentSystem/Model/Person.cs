using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Model
{
    /// <summary>
    /// Stores the personal details of a person.
    /// </summary>
    public class Person
    {
        // Default values
        public const string DEF_NAME = "No name provided";
        public const string DEF_EMAIL = "No email provided";
        public const string DEF_PHONE_NUMBER = "No phone number provided";

        // Property Accessor Methods
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address PersonAddress { get; set; }

        /// <summary>
        /// Creates a Person object using default values.
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER, new Address())
        {

        }

        /// <summary>
        /// Creates a Person object using the supplied details 
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="email">The person's email address.</param>
        /// <param name="phoneNumber">The person's phone number.</param>
        /// <param name="personAddress">The person's address.</param>
        public Person(string name, string email, string phoneNumber, Address personAddress)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            PersonAddress = personAddress;
        }

        /// <summary>
        /// Returns all personal information as a string
        /// </summary>
        /// <return>A string containing all personal details.</return>
        public override string ToString()
        {
            return "name: " + Name
                + " email: " + Email
                + " phone number: " + PhoneNumber
                + " address: " + PersonAddress;
        }
    }
}
