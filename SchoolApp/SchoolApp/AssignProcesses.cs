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
    public partial class AssignProcesses : Form
    {
        public AssignProcesses()
        {
            InitializeComponent();
        }

        private void AssignProcesses_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        // Sınıf ve ders seçildiğinde otomatik olarak dersin öğretmeni ödevi vermiş olacak

        /*
         * ödev adı 
         * bitiş tarihi
         * seçilen dersi hocası
         * derste olan öğrencilerin listesi
         */
        private void UpdateList()
        {
            foreach (Lesson lesson in Lesson.lessons)
            {
                comboBox2.Items.Add(lesson.LessonName);
            }

            foreach (Class classes in Class.classes)
            {
                comboBox1.Items.Add(classes.ClassName);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            foreach (Lesson lesson in Class.classes[comboBox1.SelectedIndex].Lessons)
            {
                comboBox2.Items.Add(lesson.LessonName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = Class.classes[comboBox1.SelectedIndex].Lessons[comboBox2.SelectedIndex].Teacher;
                string assignmentName = textBox1.Text;
                string dueDate = textBox2.Text;
                Assignment assignment = new Assignment(assignmentName, dueDate, teacher);

                foreach (Student student in Class.classes[comboBox1.SelectedIndex].Lessons[comboBox2.SelectedIndex].Students)
                {
                    assignment.AddStudent(student);
                }
                listBox1.Items.Add(assignment.AssignmentName);

                MessageBox.Show("Homework added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ödev teslim edildi");
        }
    }
}
