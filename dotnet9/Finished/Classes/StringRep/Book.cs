namespace StringRep;
class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageCount { get; }

    public Book(string name, string author, int pages)
    {
        Name = name;
        Author = author;
        PageCount = pages;
    }

    // ToString() 方法生成对象的字符串表示形式
    public override string ToString()
    {
        return $"名称: {Name}；作者：{Author}";
    }

    // ToString() 可以被重载以提供不同的格式化版本
    // 注意这不是 override 函数
    public string ToString(char format)
    {
        if (format == 'B')
        {
            return $"名称: {Name}；作者：{Author}";
        }

        if (format == 'F')
        {
            return $"名称: {Name}；作者：{Author}； 页数：{PageCount}";
        }

        return ToString();
    }
}
