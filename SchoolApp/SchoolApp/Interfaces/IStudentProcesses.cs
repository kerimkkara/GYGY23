using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface IStudentProcesses
    {
        Student AddStudent(string name);
        void StudentList();
    }
}
