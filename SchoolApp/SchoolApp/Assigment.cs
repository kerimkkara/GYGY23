using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Assignment
    {
        private static int counter = 0;
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public string DueDate { get; set; }
        public Teacher AssignedTeacher { get; set; }
        public List<Student> AssignedStudents { get; set; }

        public static List<Assignment> assignments = new List<Assignment>();

        public Assignment(string assignmentName, string dueDate, Teacher assignedTeacher)
        {
            AssignmentId = ++counter;
            AssignmentName = assignmentName;
            DueDate = dueDate;
            AssignedTeacher = assignedTeacher;
            AssignedStudents = new List<Student>();
            assignments.Add(this);
        }

    }

}
