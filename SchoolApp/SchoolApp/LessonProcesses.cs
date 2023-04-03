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
    public partial class LessonProcesses : Form
    {
        public LessonProcesses()
        {
            InitializeComponent();
        }

        private void LessonProcesses_Load(object sender, EventArgs e)
        {

            UpdateList();

        }

        private void UpdateList()
        {
            foreach (Teacher teacher in Teacher.teachers)
            {
                comboBox1.Items.Add($"{teacher.TeacherId} {teacher.TeacherName}");
            }

            foreach (Lesson lesson in Lesson.lessons)
            {
                comboBox2.Items.Add($"{lesson.LessonId} {lesson.LessonName}");
                comboBox4.Items.Add($"{lesson.LessonId} {lesson.LessonName}");
            }

            foreach (Student student in Student.students)
            {
                comboBox3.Items.Add($"{student.StudentId} {student.StudentName}");
            }
        }

        private void LessonList()
        {
            listBox1.Items.Clear();
            foreach (Lesson lesson in Lesson.lessons)
            {
                string lessonInfo = lesson.LessonId + " " + lesson.LessonName;
                listBox1.Items.Add(lessonInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTeacher = comboBox1.SelectedItem.ToString();
            int teacherId = int.Parse(selectedTeacher.Split(' ')[0]);
            Teacher teacher = Teacher.teachers.Find(t => t.TeacherId == teacherId);

            String lessonName = (String)textBox1.Text;

            Lesson lesson = new Lesson(lessonName, teacher);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LessonList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedStudent = comboBox3.SelectedItem.ToString();
            string selectedLesson = comboBox2.SelectedItem.ToString();

            Student selectedStudentObj = Student.students.Find(s => s.StudentName == selectedStudent);
            Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

            selectedLessonObj.AddStudent(selectedStudentObj);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudent = comboBox4.SelectedItem.ToString();
            Lesson selectedStudentObj = Lesson.lessons.Find(s => s.LessonName == selectedStudent);

            List<Student> studentList = selectedStudentObj.GetStudentsList();
            listBox2.Items.Clear();

            foreach (Student student in studentList)
            {
                listBox2.Items.Add(student.StudentName);
            }
        }
    }
}
