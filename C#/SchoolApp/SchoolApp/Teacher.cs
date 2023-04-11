using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Teacher : Person 
    {

        public static List<Teacher> teachers = new List<Teacher>();

        private static int counter = 0;
        private int teacherId;
        private string teacherName;

        public Teacher(string teacherName)
        {
            this.teacherId = ++counter;
            this.teacherName = teacherName;
            Teacher.teachers.Add(this);
        }

        public int TeacherId
        {
            get { return teacherId; }
        }

        public string TeacherName
        {
            get { return teacherName; }
        }

    }

}
