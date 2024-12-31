namespace Inheritance;

// TODO: 声明 Magazine 为 Publication 的子类
class Magazine
{
    private string _publisher;
    private int _pageCount;
    private decimal _price;

    // TODO: 使用 base() 关键字初始化基类
    public Magazine(string name, string publisher, int pageCount, decimal price)
    {
        _publisher = publisher;
    }

    public string Publisher
    {
        get => _publisher;
        set => _publisher = value;
    }
}

