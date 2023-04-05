using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolApp
{
    public partial class SearchProcesses : Form, ISearchProcesses
    {
        List<Lesson> lessonList = new List<Lesson>();

        public SearchProcesses()
        {
            InitializeComponent();
        }

        public void FindLessonOfStudent(Student student)
        {

            foreach (Lesson lesson in Lesson.lessons)
            {
                if (lesson.Students.Contains(student))
                {
                    lessonList.Add(lesson);
                }
            }

            listBox1.Items.Clear();

            foreach (Lesson lesson in lessonList)
            {
                listBox1.Items.Add(lesson.LessonName);
            }

        }

        public void List()
        {
            comboBox1.Items.Clear();
            foreach (Student student in Student.students)
            {
                comboBox1.Items.Add(student);
            }
        }

        private void SearchProcesses_Load(object sender, EventArgs e)
        {
            ((ISearchProcesses)this).List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedStudent = comboBox1.SelectedItem.ToString();
            Student selectedStudentObj = Student.students.Find(s => s.StudentName == selectedStudent);
            ((ISearchProcesses)this).FindLessonOfStudent(selectedStudentObj);
        }
    }
}
