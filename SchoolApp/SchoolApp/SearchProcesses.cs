using SchoolApp.Interfaces;
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

        public SearchProcesses()
        {
            InitializeComponent();
        }

        public void FindLessonOfStudent(Student student)
        {

            listBox1.Items.Clear();

            foreach (Lesson lesson in Lesson.lessons)
            {
                if (lesson.Students.Contains(student))
                {
                    listBox1.Items.Add(lesson.LessonName);
                }
            }
        }

        public void FindClassOffLesson(Lesson lesson)
        {
            listBox2.Items.Clear();
            foreach (Class clas in Class.classes)
            {
                if (clas.Lessons.Contains(lesson))
                {
                    listBox2.Items.Add(clas.ClassName);
                }
            }
        }

        public void FindTeacherOffClass(Class clas)
        {
            throw new NotImplementedException();
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
            FindLessonOfStudent(selectedStudentObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string selectedLesson = comboBox2.SelectedItem.ToString();
            Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

            FindClassOffLesson(selectedLessonObj);
        }

        
    }
}
