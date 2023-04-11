using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface ILessonProcesses
    {
        Lesson AddLesson(string name, Teacher teacher);
        void LessonList();
        void UpdateList();
        void AddStudent(Student student, Lesson lesson);
        void RemoveStudent(Student student, Lesson lesson);
    }
}
