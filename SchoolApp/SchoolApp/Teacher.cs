using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Teacher : Person 
    {

        public static List<Teacher> teachers = new List<Teacher>();

        private int teacherId;
        private string teacherName;

        public Teacher(int teacherId, string teacherName)
        {
            this.teacherId = teacherId;
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
