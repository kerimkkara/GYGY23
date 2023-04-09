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
    public partial class LessonProcesses : Form, ILessonProcesses
    {
        public LessonProcesses()
        {
            InitializeComponent();
        }

        private void LessonProcesses_Load(object sender, EventArgs e)
        {

            ((ILessonProcesses)this).UpdateList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string selectedTeacher = comboBox1.SelectedItem.ToString();
                int teacherId = int.Parse(selectedTeacher.Split(' ')[0]);
                Teacher teacher = Teacher.teachers.Find(t => t.TeacherId == teacherId);

                String lessonName = (String)textBox1.Text;

                Lesson lesson = ((ILessonProcesses)this).AddLesson(lessonName, teacher);

                MessageBox.Show($"Ders eklendi. ID: {lesson.LessonId}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((ILessonProcesses)this).LessonList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((ILessonProcesses)this).LessonList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((ILessonProcesses)this).UpdateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
           
                string selectedStudentFull = comboBox3.SelectedItem.ToString();
                string selectedStudentId = selectedStudentFull.Split(' ')[0];
                string selectedStudentName = selectedStudentFull.Split(' ')[1];

                string selectedLessonFull = comboBox2.SelectedItem.ToString();
                string selectedLessonId = selectedLessonFull.Split(' ')[0];
                string selectedLessonName = selectedLessonFull.Split(' ')[1];



                Student selectedStudentObj = Student.students.Find(s => s.StudentName == selectedStudentName);
                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLessonName);

                ((ILessonProcesses)this).AddStudent(selectedStudentObj, selectedLessonObj);

                MessageBox.Show($"Öğrenci {selectedStudentName} , {selectedLessonName}dersine başarı ile eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // hatalı

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedLessonFull = comboBox4.SelectedItem.ToString();
                string selectedLesson = selectedLessonFull.Split(' ')[1];
                Lesson selectedLessonObj = Lesson.lessons.Find(s => s.LessonName == selectedLesson);

                List<Student> studentList = selectedLessonObj.Students;
                listBox2.Items.Clear();

                foreach (Student student in studentList)
                {
                    listBox2.Items.Add(student.StudentName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Lesson AddLesson(string name, Teacher teacher)
        {
            Lesson lesson = new Lesson(name, teacher);
            return lesson;
        }


        void ILessonProcesses.LessonList()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (Lesson lesson in Lesson.lessons)
                {
                    string lessonInfo = lesson.LessonId + " " + lesson.LessonName;
                    listBox1.Items.Add(lessonInfo);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu " + ex.Message);
            }
        }

        void ILessonProcesses.UpdateList()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();


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
            } catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu "+ ex.Message );
            }
        }

        public void AddStudent(Student student, Lesson lesson)
        {
            lesson.Students.Add(student);
        }

        public void RemoveStudent(Student student, Lesson lesson)
        {
            lesson.Students.Remove(student);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStudent = comboBox3.SelectedItem.ToString();
                string selectedLesson = comboBox2.SelectedItem.ToString();

                Student selectedStudentObj = Student.students.Find(s => s.StudentName == selectedStudent);
                Lesson selectedLessonObj = Lesson.lessons.Find(l => l.LessonName == selectedLesson);

                ((ILessonProcesses)this).RemoveStudent(selectedStudentObj, selectedLessonObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
