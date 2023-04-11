using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface IClassProcesses
    {
        Class AddClass(string name, Teacher teacher);

        void AddLesson(Class clas, Lesson lesson);

        void RemoveLesson(Class clas, Lesson lesson);

        void ClassList();

        void UpdateList();
    }
}
