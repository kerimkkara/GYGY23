using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class ClassProcesses : Form
    {
        private string teacherName;
        public ClassProcesses()
        {

            InitializeComponent();
        }

        private void ClassProcesses_Load(object sender, EventArgs e)
        {
            foreach (Lesson lesson in Lesson.lessons)
            {
                comboBox1.Items.Add(lesson.LessonName);
            }

            foreach (Teacher teacher in Teacher.teachers)
            {
                comboBox2.Items.Add(teacher.TeacherName);
            }


            foreach (Class classes in Class.classes)
            {
                comboBox3.Items.Add(classes.ClassName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedClass = comboBox3.SelectedItem.ToString();
            string selectedLesson = comboBox1.SelectedItem.ToString();

            Class selectedClassObj = Class.classes.Find(c => c.ClassName == selectedClass);

            Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

            selectedClassObj.AddLesson(selectedLessonObj);
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacher = comboBox1.SelectedItem.ToString();
            teacherName = selectedTeacher;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = textBox1.Text;

            Teacher selectedTeacher = null;
            foreach (Teacher teacher in Teacher.teachers)
            {
                if (teacher.TeacherName == teacherName)
                {
                    selectedTeacher = teacher;
                    break;
                }
            }
            Class classes = new Class(className, selectedTeacher);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedClass = comboBox5.SelectedItem.ToString();
            string selectedLesson = comboBox4.SelectedItem.ToString();

            Class selectedClassObj = Class.classes.Find(c => c.ClassName == selectedClass);

            Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

            selectedClassObj.RemoveLesson(selectedLessonObj);
        }
    }
}
