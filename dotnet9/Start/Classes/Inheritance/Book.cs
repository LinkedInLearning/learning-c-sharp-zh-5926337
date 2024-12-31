namespace Inheritance;

// TODO: 声明 Book 为 Publication 的子类
class Book
{
    private string _author;
    private int _pageCount;
    private decimal _price;

    // use the base() keyword to initialize the base class
    public Book(string name, string author, int pageCount, decimal price)
    {
        _author = author;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    // TODO: use the override keyword to override a base class method

}
