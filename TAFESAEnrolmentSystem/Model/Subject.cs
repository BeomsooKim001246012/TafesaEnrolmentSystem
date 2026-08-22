using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Model
{
    /// <summary>
    ///  Stores information about a subject.
    /// </summary>
    public class Subject
    {
        // Default values 
        public const string DEF_SUBJECT_CODE = "No subject code provided";
        public const string DEF_SUBJECT_NAME = "No subject name provided";
        public const double DEF_COST = 0.0;

        // Property Accessor Methods
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Creates a subject object using default values.
        /// </summary>
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {

        }

        /// <summary>
        /// Creates a Subject object using the supplied subject details.
        /// </summary>
        /// <param name="subjectCode">The subject code.</param>
        /// <param name="subjectName">The subject name.</param>
        /// <param name="cost">The subject cost.</param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        /// <summary>
        /// Returns all subject information as a string
        /// </summary>
        /// <returns>A string containing all subject details.</returns>
        public override string ToString()
        {
            return "subject code: " + SubjectCode
                + " subject name: " + SubjectName
                + " cost: $" + Cost;
        }
    }
}
