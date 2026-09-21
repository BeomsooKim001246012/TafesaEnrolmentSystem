using NUnit.Framework;
using TAFESAEnrolmentSystem;
using TAFESAEnrolmentSystem.Model;

namespace TAFESAEnrolmentSystem.Tests
{
    [TestFixture]
    public class SearchingAndSortingTests
    {
        private Student[] CreateStudents()
        {
            Student[] students =
            {
                new Student(100005),
                new Student(100002),
                new Student(100009),
                new Student(100001),
                new Student(100010),
                new Student(100004),
                new Student(100007),
                new Student(100003),
                new Student(100008),
                new Student(100006)
            };

            return students;
        }

        [Test]
        public void LinearSearchStudentFoundTest()
        {
            Student[] students = CreateStudents();
            Student target = new Student(100007);
            int expected = 6;

            int actual =
                Utility.LinearSeachArray(students, target);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void LinearSearchStudentNotFoundTest()
        {
            Student[] students = CreateStudents();
            Student target = new Student(100011);
            int expected = -1;

            int actual =
                Utility.LinearSeachArray(students, target);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearchStudentFoundTest()
        {
            Student[] students = CreateStudents();

            Utility.BubbleSortAscending(students);

            Student target = new Student(100007);
            int expected = 6;

            int actual =
                Utility.BinarySearchArray(students, target);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BinarySearchStudentNotFoundTest()
        {
            Student[] students = CreateStudents();

            Utility.BubbleSortAscending(students);

            Student target = new Student(100011);
            int expected = -1;

            int actual =
                Utility.BinarySearchArray(students, target);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSortAscendingTest()
        {
            Student[] students = CreateStudents();

            Student[] expected =
            {
                new Student(100001),
                new Student(100002),
                new Student(100003),
                new Student(100004),
                new Student(100005),
                new Student(100006),
                new Student(100007),
                new Student(100008),
                new Student(100009),
                new Student(100010)
            };

            Utility.BubbleSortAscending(students);

            Student[] actual = students;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSortDescendingTest()
        {
            Student[] students = CreateStudents();

            Student[] expected =
            {
                new Student(100010),
                new Student(100009),
                new Student(100008),
                new Student(100007),
                new Student(100006),
                new Student(100005),
                new Student(100004),
                new Student(100003),
                new Student(100002),
                new Student(100001)
            };

            Utility.BubbleSortDescending(students);

            Student[] actual = students;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}