using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public interface IStudentProcesses
    {
        Student AddStudent(string name);
        void StudentList();
    }

    public interface ITeacherProcesses
    {
        Teacher AddTeacher(string name);
        void TeacherList();

    }

    public interface ILessonProcesses
    {
        Lesson AddLesson(string name, Teacher teacher);
        void LessonList();
        void UpdateList();

    }

    public interface ISearchProcesses
    {
        void List();
        void FindLessonOfStudent(Student student);
    }

    

}
