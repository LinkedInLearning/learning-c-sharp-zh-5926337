namespace InheritanceSample;
internal class Teacher : Person
{
    private string _teacherId;

    public string TeacherId
    {
        get => _teacherId;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("TeacherId 不能为空");
            _teacherId = value;
        }
    }

    public string Title { get; set; }
    public string Department { get; set; }

    public Teacher(string name, DateTime birthDate, string teacherId, string title, string department)
        : base(name, birthDate)
    {
        TeacherId = teacherId;
        Title = title;
        Department = department;
    }

    public override string ToString()
    {
        return $"姓名：{Name}，出生日期：{BirthDate.ToShortDateString()}，年龄：{Age}，工号：{TeacherId}，职称：{Title}，部门：{Department}";
    }

    public void Teach(string subject)
    {
        Console.WriteLine($"老师 {Name} 教授了 {subject}");
    }
}
