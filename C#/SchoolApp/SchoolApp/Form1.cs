namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }




        private void button1_Click(object sender, EventArgs e)
        {
            ClassProcesses classProcesses = new ClassProcesses();
            classProcesses.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentProcesses studentProcesses = new StudentProcesses();
            studentProcesses.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherProcesses teacherProcesses = new TeacherProcesses();
            teacherProcesses.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LessonProcesses lessonProcesses = new LessonProcesses();
            lessonProcesses.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchProcesses searchProcesses = new SearchProcesses();
            searchProcesses.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AssignProcesses assignProcesses = new AssignProcesses();
            assignProcesses.ShowDialog();
        }
    }
}