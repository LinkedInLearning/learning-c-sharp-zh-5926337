namespace InheritanceSample;
internal class Person
{
    private string _name;
    private DateTime _birthDate;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("姓名不能为空");
            _name = value;
        }
    }

    public DateTime BirthDate
    {
        get => _birthDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("出生日期不能晚于当前日期");
            if ((DateTime.Now - value).TotalDays / 365.25 > 120)
                throw new ArgumentException("年龄不能大于 120 岁");
            _birthDate = value;
        }
    }

    public int Age => (int)((DateTime.Now - BirthDate).TotalDays / 365.25);

    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public override string ToString()
    {
        return $"姓名：{Name}，出生日期：{BirthDate.ToShortDateString()}，年龄：{Age}";
    }
}
