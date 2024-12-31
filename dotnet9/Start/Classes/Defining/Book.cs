namespace Defining;

// 类的名称，在命名空间内是唯一的
public class Book
{
    // TODO: 类使用成员变量，或“字段”来保存数据
    string _name;
    string _author;
    int _pageCount;

    // TODO: 类有一个或多个构造函数
    public Book(string name, string author, int pageCount)
    {
        _name = name;
        _author = author;
        _pageCount = pageCount;
    }

    // TODO: 方法用于操作类和数据
    public string GetDescription()
    {
        return $"{_name} 作者：{_author}, {_pageCount} 页";
    }
}

