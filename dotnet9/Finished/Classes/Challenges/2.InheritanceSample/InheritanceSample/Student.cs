namespace InheritanceSample;
internal class Student : Person
{
    private string _studentId;
    private int _grade;

    public string StudentId
    {
        get => _studentId;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("StudentId 不能为空");
            _studentId = value;
        }
    }

    public string Major { get; set; }

    public int Grade
    {
        get => _grade;
        set
        {
            if (value <= 0 || value > 4)
                throw new ArgumentException("Grade 必须在 1 和 4 之间");
            _grade = value;
        }
    }

    public Student(string name, DateTime birthDate, string studentId, string major, int grade)
        : base(name, birthDate)
    {
        StudentId = studentId;
        Major = major;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"姓名：{Name}，出生日期：{BirthDate.ToShortDateString()}，年龄：{Age}，学号：{StudentId}，专业：{Major}，年级：{Grade}";
    }

    public void Study(string subject)
    {
        Console.WriteLine($"学生 {Name} 学习了 {subject}");
    }
}
