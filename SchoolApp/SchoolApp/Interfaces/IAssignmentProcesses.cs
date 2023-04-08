using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interfaces
{
    public interface IAssignmentProcesses
    {
        Assignment AddAssigment(string assignmentName, string dueDate, Teacher teacher);
        void AddStudent(Student student, Assignment assignment);
        void RemoveStudent(Student student, Assignment assignment);

        void AddHomework(Assignment assignment);
        void SendHomework();
        void UpdateList();
    }
}
