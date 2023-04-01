using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{

    public interface IStudent
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
    }

    public interface ILesson
    {
        int LessonId { get; set; }
        string LessonName { get; set; }
    }



}
