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
    public partial class AssignProcesses : Form, IAssignmentProcesses
    {
        public AssignProcesses()
        {
            InitializeComponent();
        }

        private void AssignProcesses_Load(object sender, EventArgs e)
        {

            ((IAssignmentProcesses)this).UpdateList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();

                foreach (Lesson lesson in Class.classes[comboBox1.SelectedIndex].Lessons)
                {
                    comboBox2.Items.Add(lesson.LessonName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = Class.classes[comboBox1.SelectedIndex].Lessons[comboBox2.SelectedIndex].Teacher;
                string assignmentName = textBox1.Text;
                string dueDate = textBox2.Text;

                Assignment assignment = AddAssigment(assignmentName, dueDate, teacher);
                AddHomework(assignment);
                MessageBox.Show("Homework added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SendHomework();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
            }
        }

        public void AddStudent(Student student, Assignment assignment)
        {
            assignment.AssignedStudents.Add(student);
        }

        public void RemoveStudent(Student student, Assignment assignment)
        {
            assignment.AssignedStudents.Remove(student);
        }

        public Assignment AddAssigment(string assignmentName, string dueDate, Teacher teacher)
        {
            Assignment assignment = new Assignment(assignmentName, dueDate, teacher);
            return assignment;
        }

        void IAssignmentProcesses.UpdateList()
        {
            try
            {
                foreach (Lesson lesson in Lesson.lessons)
                {
                    comboBox2.Items.Add(lesson.LessonName);
                    comboBox4.Items.Add(lesson.LessonName);
                }

                foreach (Class classes in Class.classes)
                {
                    comboBox1.Items.Add(classes.ClassName);
                    comboBox3.Items.Add(classes.ClassName);
                }

                foreach ( Student student in Student.students)
                {
                    comboBox5.Items.Add(student.StudentName);
                }

                foreach (Assignment assignment in Assignment.assignments)
                {
                    comboBox6.Items.Add(assignment.AssignmentName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu", ex.Message);
            }
        }

        public void AddHomework(Assignment assignment)
        {
            foreach (Student student in Class.classes[comboBox1.SelectedIndex].Lessons[comboBox2.SelectedIndex].Students)
            {
                ((IAssignmentProcesses)this).AddStudent(student, assignment);
            }
            listBox1.Items.Add(assignment.AssignmentName);
        }

        public void SendHomework()
        {
            MessageBox.Show("Ödev teslim edildi");
        }
    }
}
