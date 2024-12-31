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

    // TODO: ToString() 方法生成对象的字符串表示形式


    // TODO: ToString() 可以被重载以提供不同的格式化版本
    // 注意这不是 override 函数

}
