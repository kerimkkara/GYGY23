using SchoolApp;

public class Lesson
{
    public static List<Lesson> lessons = new List<Lesson>();

    private static int counter = 0;
    private int lessonId;
    private string lessonName;
    private Teacher teacher;
    private List<Student> students = new List<Student>();

    public Lesson(string lessonName, Teacher teacher)
    {
        this.lessonId = ++counter;
        this.lessonName = lessonName;
        this.teacher = teacher;
        Lesson.lessons.Add(this);
    }

    public int LessonId
    {
        get { return lessonId; }
    }

    public string LessonName
    {
        get { return lessonName; }
    }

    public Teacher Teacher
    {
        get { return teacher; }
    }

    public List<Student> Students
    {
        get { return students; }
    }
    
}