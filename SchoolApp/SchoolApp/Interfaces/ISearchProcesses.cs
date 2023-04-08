using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface ISearchProcesses
    {
        void List();
        void FindLessonOfStudent(Student student);

        void FindClassOffLesson(Lesson lesson);

        void FindTeacherOffClass(Class clas);
    }

}
