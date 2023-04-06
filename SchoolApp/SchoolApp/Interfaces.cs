using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        void AddStudent(Student student, Lesson lesson);
        void RemoveStudent(Student student , Lesson lesson);
    }


    public interface ISearchProcesses
    {
        void List();
        void FindLessonOfStudent(Student student);
    }


    public interface IAssignmentProcesses
    {
        void AddStudent(Student student, Assignment assignment);
        void RemoveStudent(Student student, Assignment assignment);
    }

    public interface IClassProcesses
    {
        Class AddClass(string name, Teacher teacher);

        void AddLesson(Class clas, Lesson lesson);

        void RemoveLesson(Class clas, Lesson lesson);
    }


}
