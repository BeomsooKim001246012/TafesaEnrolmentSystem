using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Model
{
    /// <summary>
    /// Stores information about a student.
    /// </summary>
    public class Student : Person, IComparable<Student>
    {
        // Default values
        public const int DEF_STUDENT_ID = -1;
        public const string DEF_PROGRAM = "No program provided";

        // Property Accessor Methods
        public int StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }

        /// <summary>
        /// Creates a Student object using default values.
        /// </summary>
        public Student() : this(DEF_STUDENT_ID)
        {
        }

        /// <summary>
        /// Creates a Student object using only a student ID.
        /// </summary>
        /// <param name="studentID">
        /// The student's unique ID.
        /// </param>
        public Student(int studentID) : this(Person.DEF_NAME, Person.DEF_EMAIL, Person.DEF_PHONE_NUMBER, new Address(), studentID, DEF_PROGRAM, DateTime.MinValue, new Enrollment())
        {
        }

        /// <summary>
        /// Creates a Student object using all supplied details.
        /// </summary>
        /// <param name="name">The student's name.</param>
        /// <param name="email">
        /// The student's email address.
        /// </param>
        /// <param name="phoneNumber">
        /// The student's phone number.
        /// </param>
        /// <param name="personAddress">
        /// The student's address.
        /// </param>
        /// <param name="studentID">
        /// The student's unique ID.
        /// </param>
        /// <param name="program">
        /// The student's program.
        /// </param>
        /// <param name="dateRegistered">
        /// The registration date.
        /// </param>
        /// <param name="studentEnrollment">
        /// The student's enrolment.
        /// </param>
        public Student(string name, string email, string phoneNumber, Address personAddress, int studentID, string program, DateTime dateRegistered, Enrollment studentEnrollment)
            : base(name, email, phoneNumber, personAddress)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = studentEnrollment;
        }

        /// <summary>
        /// Determines whether this student and another object
        /// represent the same student.
        /// </summary>
        /// <param name="obj">
        /// The object to compare with this student.
        /// </param>
        /// <returns>
        /// True when both objects have the same student ID;
        /// otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student student = (Student)obj;

            return student.StudentID == this.StudentID;
        }

        /// <summary>
        /// Returns a hash code based on the student ID.
        /// </summary>
        /// <returns>
        /// The hash code for the student ID.
        /// </returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Compares this student with another student
        /// using StudentID.
        /// </summary>
        /// <param name="other">
        /// The student to compare with this student.
        /// </param>
        /// <returns>
        /// A negative value when this student ID is smaller,
        /// zero when the student IDs are equal, or a positive
        /// value when this student ID is greater.
        /// </returns>
        public int CompareTo(Student other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            return StudentID.CompareTo(other.StudentID);
        }

        /// <summary>
        /// Determines whether two Student objects are equal.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the Student objects are equal;
        /// otherwise, false.
        /// </returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Determines whether two Student objects are not equal.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the Student objects are not equal;
        /// otherwise, false.
        /// </returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        /// <summary>
        /// Determines whether the first student has
        /// a smaller StudentID.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the first StudentID is smaller.
        /// </returns>
        public static bool operator <(Student student1, Student student2)
        {
            return Comparer<Student>.Default.Compare(student1,student2) < 0;
        }

        /// <summary>
        /// Determines whether the first student has
        /// a greater StudentID.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the first StudentID is greater.
        /// </returns>
        public static bool operator >(Student student1, Student student2)
        {
            return Comparer<Student>.Default.Compare(student1, student2) > 0;
        }

        /// <summary>
        /// Determines whether the first StudentID is less
        /// than or equal to the second StudentID.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the first StudentID is less than or
        /// equal to the second StudentID.
        /// </returns>
        public static bool operator <=(Student student1, Student student2)
        {
            return Comparer<Student>.Default.Compare(student1, student2) <= 0;
        }

        /// <summary>
        /// Determines whether the first StudentID is greater
        /// than or equal to the second StudentID.
        /// </summary>
        /// <param name="student1">The first student.</param>
        /// <param name="student2">The second student.</param>
        /// <returns>
        /// True when the first StudentID is greater than or
        /// equal to the second StudentID.
        /// </returns>
        public static bool operator >=(Student student1, Student student2)
        {
            return Comparer<Student>.Default.Compare(student1, student2) >= 0;
        }

        /// <summary>
        /// Returns all student information as a string.
        /// </summary>
        /// <returns>
        /// A string containing all student details.
        /// </returns>
        public override string ToString()
        {
            return base.ToString()
                + " student ID: " + StudentID
                + " program: " + Program
                + " date registered: "
                + DateRegistered.ToShortDateString()
                + " enrollment: " + StudentEnrollment;
        }
    }
}
