using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Model
{
    /// <summary>
    /// Stores a student's enrollment information
    /// </summary>
    public class Enrollment
    {
        // Default values
        public const string DEF_GRADE = "No grade provided";
        public const int DEF_SEMESTER = -1;

        // Property Accessor Methods
        public DateTime DateEnrolled {  get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }
        public Subject EnrolledSubject { get; set; }

        /// <suumary>
        /// Creates an Enrollment object using default values.
        /// </suumary>
        public Enrollment() : this(DateTime.MinValue, DEF_GRADE, DEF_SEMESTER, new Subject())
        {

        }

        /// <summary>
        /// Creates an Enrollment object using the supplied details.
        /// </summary>
        /// <param name="dateEnrolled">The enrolment date.</param>
        /// <param name="grade">The student's grade.</param>
        /// <param name="semester">The enrolment semester.</param>
        /// <param name="enrolledSubject">The enrolled subject.</param>
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject enrolledSubject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            EnrolledSubject = enrolledSubject;
        }

        /// <summary>
        /// Returns all enrolment information as a string.
        /// </summary>
        /// <returns>A string containing all enrolment details.</returns>
        public override string ToString()
        {
            return "date enrolled: " + DateEnrolled.ToShortDateString()
                + " grade: " + Grade
                + " semester: " + Semester
                + " subject: " + EnrolledSubject;
        }
    }
}
