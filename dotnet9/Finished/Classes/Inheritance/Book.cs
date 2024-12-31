namespace Inheritance;

// 声明 Book 为 Publication 的子类
class Book : Publication
{
    private string _author;

    // 使用 base() 关键字初始化基类
    public Book(string name, string author, int pageCount, decimal price)
        : base(name, pageCount, price)
    {
        _author = author;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    // 使用 override 关键字重写基类方法
    public override string GetDescription()
    {
        return $"{Name} 作者：{Author}, {PageCount} 页";
    }
}
