namespace Inheritance;

// 声明 Magazine 为 Publication 的子类
class Magazine : Publication
{
    private string _publisher;

    // 使用 base() 关键字初始化基类
    public Magazine(string name, string publisher, int pageCount, decimal price)
         : base(name, pageCount, price)
    {
        _publisher = publisher;
    }

    public string Publisher
    {
        get => _publisher;
        set => _publisher = value;
    }
}

