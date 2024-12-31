namespace Inheritance;

// TODO: 声明 Book 为 Publication 的子类
class Book
{
    private string _author;
    private int _pageCount;
    private decimal _price;

    // TODO: 使用 base() 关键字初始化基类
    public Book(string name, string author, int pageCount, decimal price)
    {
        _author = author;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    // TODO: 使用 override 关键字重写基类方法

}
