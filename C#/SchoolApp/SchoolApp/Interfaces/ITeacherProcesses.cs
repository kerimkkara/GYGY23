using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface ITeacherProcesses
    {
        Teacher AddTeacher(string name);
        void TeacherList();

    }
}
