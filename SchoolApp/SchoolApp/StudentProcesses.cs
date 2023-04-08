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

namespace SchoolApp
{
    public partial class StudentProcesses : Form, IStudentProcesses
    {
        public StudentProcesses()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Öğrenci adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Student student = ((IStudentProcesses)this).AddStudent(studentName);
                MessageBox.Show($"Öğrenci eklendi. ID: {student.StudentId}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((IStudentProcesses)this).StudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentProcesses_Load(object sender, EventArgs e)
        {
            ((IStudentProcesses)this).StudentList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((IStudentProcesses)this).StudentList();
        }

        Student IStudentProcesses.AddStudent(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Öğrenci adı boş olamaz.");

            Student student = new Student(name);
            return student;
        }

        void IStudentProcesses.StudentList()
        {
            listBox1.Items.Clear();
            foreach (Student student in Student.students)
            {
                string studentInfo = $"{student.StudentId} {student.StudentName}";
                listBox1.Items.Add(studentInfo);
            }
        }
    }


}
