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
    public partial class StudentProcesses : Form
    {
        public StudentProcesses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String studentName = (String)textBox1.Text;
            Student student = new Student(studentName);
        }

        private void StudentProcesses_Load(object sender, EventArgs e)
        {
            StudentList();
        }

        private void StudentList()
        {
            listBox1.Items.Clear();
            foreach (Student student in Student.students)
            {
                string studentInfo = student.StudentId + " " + student.StudentName;
                listBox1.Items.Add(studentInfo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentList();
        }
    }
}
