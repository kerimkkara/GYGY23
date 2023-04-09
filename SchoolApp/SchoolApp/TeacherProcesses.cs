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
    public partial class TeacherProcesses : Form , ITeacherProcesses
    {
        public TeacherProcesses()
        {
            InitializeComponent();
        }

        private void TeacherProcesses_Load(object sender, EventArgs e)
        {
            ((ITeacherProcesses)this).TeacherList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teacherName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(teacherName))
            {
                MessageBox.Show("Öğretmen adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Teacher teacher = ((ITeacherProcesses)this).AddTeacher(teacherName);
                MessageBox.Show($"Öğretmen eklendi. ID: {teacher.TeacherId}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((ITeacherProcesses)this).TeacherList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((ITeacherProcesses)this).TeacherList();
        }

        Teacher ITeacherProcesses.AddTeacher(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Öğretmen adı boş bırakılamaz");
            }

            Teacher teacher = new Teacher(name);
            return teacher;
        }

        void ITeacherProcesses.TeacherList()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (Teacher teacher in Teacher.teachers)
                {
                    string teacherInfo = teacher.TeacherId + " " + teacher.TeacherName;
                    listBox1.Items.Add(teacherInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message);
            }
        }
    }
}
