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
using System.Xml.Serialization;

namespace SchoolApp
{
    public partial class ClassProcesses : Form , IClassProcesses
    {
        private string teacherName;
        public ClassProcesses()
        {
            InitializeComponent();
        }

        private void ClassProcesses_Load(object sender, EventArgs e)
        {

            ((IClassProcesses)this).UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = comboBox3.SelectedItem.ToString();
                string selectedLesson = comboBox1.SelectedItem.ToString();

                Class selectedClassObj = Class.classes.Find(c => c.ClassName == selectedClass);

                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

                ((IClassProcesses)this).AddLesson(selectedClassObj, selectedLessonObj);

                MessageBox.Show("Lesson added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string className = textBox1.Text;
                string teacherName = comboBox2.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(className))
                {
                    throw new Exception("Class name cannot be empty.");
                }

                if (comboBox2.SelectedItem == null)
                {
                    throw new Exception("Please select a teacher for the class.");
                }


                Teacher selectedTeacher = Teacher.teachers.Find(t => t.TeacherName == teacherName);

                if (selectedTeacher == null)
                {
                    throw new Exception("Selected teacher is not valid.");
                }

                Class class1 =   ((IClassProcesses)this).AddClass(className, selectedTeacher);

                MessageBox.Show($"Sınıf eklendi. ID: {class1.ClassId}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((IClassProcesses)this).ClassList();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a teacher for the class.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = comboBox5.SelectedItem.ToString();
                string selectedLesson = comboBox4.SelectedItem.ToString();

                Class selectedClassObj = Class.classes.Find(c => c.ClassName == selectedClass);

                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

                ((IClassProcesses)this).RemoveLesson(selectedClassObj, selectedLessonObj);

                MessageBox.Show("Lesson removed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            ((IClassProcesses)this).UpdateList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ((IClassProcesses)this).ClassList();
        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = comboBox6.SelectedItem.ToString();
                Class selectedClassObj = Class.classes.Find(c => c.ClassName == selectedClass);

                List<Lesson> lessonList = selectedClassObj.Lessons;
                listBox2.Items.Clear();

                foreach (Lesson lesson in lessonList)
                {
                    listBox2.Items.Add(lesson.LessonName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Class AddClass(string name, Teacher teacher)
        {
            Class classes = new Class(name, teacher);
            return classes;
        }

        public void AddLesson(Class clas, Lesson lesson)
        {
            clas.Lessons.Add(lesson);
        }

        public void RemoveLesson(Class clas, Lesson lesson)
        {
            clas.Lessons.Remove(lesson);
        }

        public void ClassList()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (Class classes in Class.classes)
                {
                    string classInfo = (classes.ClassId + " " + classes.ClassName);
                    listBox1.Items.Add(classInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void IClassProcesses.UpdateList()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            foreach (Lesson lesson in Lesson.lessons)
            {
                comboBox1.Items.Add(lesson.LessonName);
                comboBox4.Items.Add(lesson.LessonName);
                

            }

            foreach (Teacher teacher in Teacher.teachers)
            {
                comboBox2.Items.Add(teacher.TeacherName);
            }


            foreach (Class classes in Class.classes)
            {
                comboBox3.Items.Add(classes.ClassName);
                comboBox6.Items.Add(classes.ClassName);
                comboBox5.Items.Add(classes.ClassName);
            }
        }
    }
}
