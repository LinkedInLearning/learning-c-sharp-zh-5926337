namespace Properties;

// 类的名称在命名空间内是唯一的
class Book
{
    // 类有实例变量来保存数据
    private string _name;
    private string _author;
    private int _pageCount;

    // 类有一个或多个构造函数
    public Book(string name, string author, int pages)
    {
        _name = name;
        _author = author;
        _pageCount = pages;
    }

    // 使用属性来访问内部数据。这被称为带有“后备字段”的属性
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // 使用 => 操作符的简写方式来创建“表达式主体”属性
    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public int PageCount
    {
        get => _pageCount;
        set => _pageCount = value;
    }

    // 如果你想阻止修改或读取值，或者想从其他字段创建“计算属性”，则可以省略 get 或 set
    public string Description
    {
        get => $"{Name} 作者：{Author}, {PageCount} 页";
    }

    // 属性可以自动生成 - 如果没有后备字段，则属性可以保存数据
    public string ISBN
    {
        get; set;
    }
    public decimal Price
    {
        get; set;
    }
}

