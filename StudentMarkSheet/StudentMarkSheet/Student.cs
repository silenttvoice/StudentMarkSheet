using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;

namespace StudentMarkSheet
{
    [Serializable()] // Set this attributes to all classes that want to serialize
    public class Student : ISerializable, IComparable
    {
        // Fields
        private string studentID;
        private string surName;
        private string firstName;
        private string emailAddress;
        private double courseWork1;
        private double courseWork2;
        private double finalExam;

        // Method
        public Student(string studentIDnum)
        {
            this.studentID = studentIDnum;
        }

        // Properties
        // Default constructor
        public string StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string SurName
        {
            get { return this.surName; }
            set { this.surName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string EmailAddress
        {
            get { return this.emailAddress; }
            set { this.emailAddress = value; }
        }

        public double CourseWork1
        {
            get { return this.courseWork1; }
            set { this.courseWork1 = value; }
        }

        public double CourseWork2
        {
            get { return this.courseWork2; }
            set { this.courseWork2 = value; }
        }

        public double FinalExam
        {
            get { return this.finalExam; }
            set { this.finalExam = value; }
        }

        // Method
        // Get the values from info and assign them to their appropriate properties
        // Desrialization constructor
        public Student(SerializationInfo info, StreamingContext ctxt)
        {
            this.studentID = "";
            this.surName = "";
            this.firstName = "";
            this.emailAddress = "";
            this.courseWork1 = 0.0;
            this.courseWork2 = 0.0;
            this.finalExam = 0.0;
            this.StudentID = (string)info.GetValue("StudentID", typeof(string));
            this.SurName = (string)info.GetValue("SurName", typeof(string));
            this.FirstName = (string)info.GetValue("FirstName", typeof(string));
            this.EmailAddress = (string)info.GetValue("EmailAddress", typeof(string));
            this.CourseWork1 = (double)info.GetValue("CourseWork1", typeof(double));
            this.CourseWork2 = (double)info.GetValue("CourseWork2", typeof(double));
            this.FinalExam = (double)info.GetValue("FinalExam", typeof(double));
        }

        // Method
        // Add the value for every fields
        // Serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("StudentID", this.studentID);
            info.AddValue("SurName", this.surName);
            info.AddValue("FirstName", this.firstName);
            info.AddValue("EmailAddress", this.emailAddress);
            info.AddValue("CourseWork1", this.courseWork1);
            info.AddValue("CourseWork2", this.courseWork2);
            info.AddValue("FinalExam", this.finalExam);
        }

        // Method
        // Provide default sort order for the Student objects using the surname of a student
        public int CompareTo(object obj)
        {
            if (!(obj is Student)) // If the object is not student
            {
                throw new ArgumentException("object is not a student"); // Display message 
            }
            Student student = (Student)obj; // If it is student
            return this.SurName.CompareTo(student.SurName); // Compare and sort in order of surname
        }

        // Method 
        // Calculating 30% of cw1, cw2 and 40% of final exam
        public double CourseMark()
        {
            return (((this.courseWork1 * 0.3) + (this.courseWork2 * 0.3) + (this.finalExam * 0.4)));
        }

        // Method
        // Nested class to do the sorting by aggregated mark
        private class sortByCourseMarkHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student student = (Student)a;
                Student student2 = (Student)b;
                if (student.CourseMark() < student2.CourseMark())
                {
                    return -1; 
                }
                if (student.CourseMark() == student2.CourseMark())
                {
                    return 0;
                }
                return 1;
            }
        }

        // Method
        // Using IComparer to compare by aggregated mark
        public static IComparer sortByCourseMark()
        {
            return (IComparer)new sortByCourseMarkHelper();
        }
    }
}
