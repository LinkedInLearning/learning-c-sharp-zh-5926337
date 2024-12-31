namespace Inheritance;

class Publication
{
    private string _name;

    public Publication(string name, int pageCount, decimal price)
    {
        _name = name;
        PageCount = pageCount;
        Price = price;
    }

    // PageCount 属性没有后备字段
    public int PageCount
    {
        get; set;
    }

    public decimal Price
    {
        get; set;
    }

    public string Name
    {
        // 返回 _name
        get { return _name; }

        // 使用 setter 来验证新的属性值
        set
        {
            if (value == "")
            {
                throw new ArgumentException("名称不能为空");
            }
            _name = value;
        }
    }

    // 使用 virtual 关键字来指示一个方法可以被子类重写以自定义行为

}
