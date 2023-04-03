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
    public partial class TeacherProcesses : Form
    {
        public TeacherProcesses()
        {
            InitializeComponent();
        }

        private void TeacherProcesses_Load(object sender, EventArgs e)
        {
            TeacherList();
        }

        private void TeacherList()
        {
            listBox1.Items.Clear();
            foreach (Teacher teacher in Teacher.teachers)
            {
                string teacherInfo = teacher.TeacherId + " " + teacher.TeacherName;
                listBox1.Items.Add(teacherInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TeacherName = (String)textBox1.Text;
            Teacher teacher = new Teacher(TeacherName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherList();
        }
    }
}
