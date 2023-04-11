using SchoolApp;

public class Class
{
    public static List<Class> classes = new List<Class>();

    private static int counter = 1;
    private int classId;
    private string className;
    private Teacher guidanceCounselor;
    private List<Lesson> lessons = new List<Lesson>();

    public Class(string className, Teacher guidanceCounselor)
    {
        this.classId = ++counter;
        this.className = className;
        this.guidanceCounselor = guidanceCounselor;
        Class.classes.Add(this);
    }

    public int ClassId
    {
        get { return classId; }
    }

    public string ClassName
    {
        get { return className; }
    }

    public Teacher GuidanceCounselor
    {
        get { return guidanceCounselor; }
    }

    public List<Lesson> Lessons
    {
        get { return lessons; }
    }

}
