namespace Modifiers;

// 访问修饰符控制如何访问属性和方法
class Book
{
    // TODO: public 成员和方法可以被任何其他代码访问。
    // 注意：这不是暴露内部数据的正确方法
    string _name;

    // TODO: protected 成员和方法只能被当前类或派生类访问
    string _author;

    // TODO: private 是默认的访问修饰符，private 成员和方法只能被当前类内部的代码访问
    int _pageCount;

    public Book(string name, string author, int pages)
    {
        _name = name;
        _author = author;
        _pageCount = pages;
    }

    public string GetDescription()
    {
        return $"{_name} 作者：{_author}, {_pageCount} 页";
    }

    // TODO: 成员变量可以通过方法访问

}
