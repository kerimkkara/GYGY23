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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        public void FindClassOffLesson(Lesson lesson)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void FindTeacherOffLesson(Lesson lesson)
        {
            try
            {
                listBox3.Items.Clear();

                string teacher = ($"{lesson.Teacher.TeacherId} {lesson.Teacher.TeacherName}");
                listBox3.Items.Add(teacher);
                MessageBox.Show("Başarı ile bulundu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        public void List()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                foreach (Student student in Student.students)
                {
                    comboBox1.Items.Add(student.StudentName);
                }

                foreach (Lesson lesson in Lesson.lessons)
                {
                    comboBox2.Items.Add(lesson.LessonName);
                    comboBox3.Items.Add(lesson.LessonName);
                }


                MessageBox.Show("Listeler başarı ile yüklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void SearchProcesses_Load(object sender, EventArgs e)
        {
            ((ISearchProcesses)this).List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStudent = comboBox1.SelectedItem.ToString();
                Student selectedStudentObj = Student.students.Find(s => s.StudentName == selectedStudent);
                FindLessonOfStudent(selectedStudentObj);
                MessageBox.Show("Arama işlemi başarılı");
            } catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string selectedLesson = comboBox2.SelectedItem.ToString();
                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

                FindClassOffLesson(selectedLessonObj);
            } catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedLesson = comboBox3.SelectedItem.ToString();
                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

                FindTeacherOffLesson(selectedLessonObj);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu " + ex.Message);
            }
        }
    }
}
