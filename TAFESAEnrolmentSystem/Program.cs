using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESAEnrolmentSystem.Model;

namespace TAFESAEnrolmentSystem
{
    /// <summary>
    /// Tests all model constructors, properties and methods.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Test Address class
            Console.WriteLine("===== ADDRESS TESTING =====");

            // Test no-argument constructor
            Address defaultAddress = new Address();
            Console.WriteLine("Default address:");
            Console.WriteLine(defaultAddress.ToString());

            // Test all-argument constructor
            Address address = new Address(10, "King William Street", "Adelaide", "5000", "SA");
            Console.WriteLine("All-argument address:");
            Console.WriteLine(address.ToString());

            // Test Address properties
            defaultAddress.StreetNum = 20;
            defaultAddress.StreetName = "North Terrace";
            defaultAddress.Suburb = "Adelaide";
            defaultAddress.Postcode = "5000";
            defaultAddress.State = "SA";

            Console.WriteLine("Updated address properties:");
            Console.WriteLine("Street number: " + defaultAddress.StreetNum);
            Console.WriteLine("Street name: " + defaultAddress.StreetName);
            Console.WriteLine("Suburb: " + defaultAddress.Suburb);
            Console.WriteLine("Postcode: " + defaultAddress.Postcode);
            Console.WriteLine("State: " + defaultAddress.State);
            Console.WriteLine();

            // Test Person class
            Console.WriteLine("===== PERSON TESTING =====");

            // Test no-argument constructor
            Person defaultPerson = new Person();
            Console.WriteLine("Default person:");
            Console.WriteLine(defaultPerson.ToString());

            // Test all-argument constructor
            Person person = new Person("Kim Beomsoo", "beomsoo@example.com", "0400000000", address);

            Console.WriteLine("All-argument person:");
            Console.WriteLine(person.ToString());

            // Test Person properties
            defaultPerson.Name = "Test Person";
            defaultPerson.Email = "test@example.com";
            defaultPerson.PhoneNumber = "0411111111";
            defaultPerson.PersonAddress = defaultAddress;

            Console.WriteLine("Updated person properties:");
            Console.WriteLine("Name: " + defaultPerson.Name);
            Console.WriteLine("Email: " + defaultPerson.Email);
            Console.WriteLine("Phone number: " + defaultPerson.PhoneNumber);
            Console.WriteLine("Address: " + defaultPerson.PersonAddress);
            Console.WriteLine();

            // Test Subject class
            Console.WriteLine("===== SUBJECT TESTING =====");

            // Test no-argument constructor
            Subject defaultSubject = new Subject();
            Console.WriteLine("Default subject:");
            Console.WriteLine(defaultSubject.ToString());

            // Test all-argument constructor
            Subject subject = new Subject("ICTPRG547", "Data Structures and Algorithms", 750.00);

            Console.WriteLine("All-argument subject:");
            Console.WriteLine(subject.ToString());

            // Test Subject properties
            defaultSubject.SubjectCode = "ICTPRG546";
            defaultSubject.SubjectName = "Advanced Programming";
            defaultSubject.Cost = 700.00;

            Console.WriteLine("Updated subject properties:");
            Console.WriteLine("Subject code: " + defaultSubject.SubjectCode);
            Console.WriteLine("Subject name: " + defaultSubject.SubjectName);
            Console.WriteLine("Cost: $" + defaultSubject.Cost);
            Console.WriteLine();

            // Test Enrollment class
            Console.WriteLine("===== ENROLLMENT TESTING =====");

            // Test no-argument constructor
            Enrollment defaultEnrollment = new Enrollment();
            Console.WriteLine("Default enrollment:");
            Console.WriteLine(defaultEnrollment.ToString());

            // Test all-argument constructor
            Enrollment enrollment = new Enrollment(new DateTime(2026, 8, 17), "A", 2, subject);

            Console.WriteLine("All-argument enrollment:");
            Console.WriteLine(enrollment.ToString());

            // Test Enrollment properties
            defaultEnrollment.DateEnrolled = new DateTime(2026, 7, 20);
            defaultEnrollment.Grade = "B";
            defaultEnrollment.Semester = 2;
            defaultEnrollment.EnrolledSubject = defaultSubject;

            Console.WriteLine("Updated enrollment properties:");
            Console.WriteLine("Date enrolled: " + defaultEnrollment.DateEnrolled.ToShortDateString());
            Console.WriteLine("Grade: " + defaultEnrollment.Grade);
            Console.WriteLine("Semester: " + defaultEnrollment.Semester);
            Console.WriteLine("Subject: " + defaultEnrollment.EnrolledSubject);
            Console.WriteLine();

            // Test Student class
            Console.WriteLine("===== STUDENT TESTING =====");

            // Test no-argument constructor
            Student defaultStudent = new Student();
            Console.WriteLine("Default student:");
            Console.WriteLine(defaultStudent.ToString());

            // Test student-ID-only constructor
            Student studentIDOnly = new Student(100001);
            Console.WriteLine("Student-ID-only constructor:");
            Console.WriteLine(studentIDOnly.ToString());

            // Test all-argument constructor
            Student student1 = new Student("Kim Beomsoo", "beomsoo@example.com", "0400000000", address, 100001,
            "Diploma of Information Technology", new DateTime(2026, 1, 27), enrollment);

            Console.WriteLine("All-argument student:");
            Console.WriteLine(student1.ToString());

            // Test Student properties
            defaultStudent.StudentID = 100003;
            defaultStudent.Program = "Certificate IV in Information Technology";
            defaultStudent.DateRegistered = new DateTime(2026, 2, 2);
            defaultStudent.StudentEnrollment = defaultEnrollment;

            Console.WriteLine("Updated student properties:");
            Console.WriteLine("Student ID: " + defaultStudent.StudentID);
            Console.WriteLine("Program: " + defaultStudent.Program);
            Console.WriteLine("Date registered: " + defaultStudent.DateRegistered.ToShortDateString());
            Console.WriteLine("Enrollment: " + defaultStudent.StudentEnrollment);
            Console.WriteLine();

            // Test Student equality methods
            Console.WriteLine("===== EQUALITY TESTING =====");

            Student student2 = new Student(100001);
            Student student3 = new Student(100002);

            Console.WriteLine("Same reference using Equals: " + student1.Equals(student1));

            Console.WriteLine("Same student ID using Equals: " + student1.Equals(student2));

            Console.WriteLine("Different student ID using Equals: " + student1.Equals(student3));

            Console.WriteLine("Compare with null using Equals: " + student1.Equals(null));

            Console.WriteLine("Compare with Person using Equals: " + student1.Equals(person));

            Console.WriteLine("Student 1 hash code: " + student1.GetHashCode());

            Console.WriteLine("Student 2 hash code: " + student2.GetHashCode());

            Console.WriteLine("Same IDs have same hash code: " + (student1.GetHashCode() == student2.GetHashCode()));

            Console.WriteLine("Same IDs using ==: " + (student1 == student2));

            Console.WriteLine("Different IDs using !=: " + (student1 != student3));

            Console.WriteLine();
            Console.WriteLine("All tests completed.");
            Console.WriteLine("Press Enter to close.");

            Console.ReadLine();
        }
    }

}

