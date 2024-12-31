namespace Modifiers;

// 访问修饰符控制如何访问属性和方法
class Book
{
    // public 成员和方法可以被任何其他代码访问。
    // 注意：这不是暴露内部数据的正确方法
    public string _name;

    // protected 成员和方法只能被当前类或派生类访问
    protected string _author;

    // private 是默认的访问修饰符，private 成员和方法只能被当前类内部的代码访问
    private int _pageCount;

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

    // 成员变量可以通过方法访问
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetPageCount(int count)
    {
        _pageCount = count;
    }
}

