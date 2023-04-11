using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Student : Person
    {
        public static List<Student> students = new List<Student>();

        private static int counter = 0;
        private int studentId;
        private string studentName;

        public Student(string studentName)
        {
            this.studentId = ++counter;
            this.studentName = studentName;
            Student.students.Add(this);
        }

        public int StudentId
        {
            get { return studentId; }
        }

        public string StudentName
        {
            get { return studentName; }
        }
    }


}
