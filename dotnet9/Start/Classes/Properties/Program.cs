using Properties;

// 创建一个新的 Book 对象
Book b1 = new Book("活着", "余华", 191);

// 访问一些属性
Console.WriteLine(b1.Name);
Console.WriteLine(b1.Description);

// 设置 ISBN 和 Price 属性
b1.ISBN = "9787506365437";
b1.Price = 27.7m;
Console.WriteLine(b1.ISBN);
Console.WriteLine(b1.Price);

// 更改 Name 和 PageCount 属性
b1.Name = "许三观卖血记";
b1.PageCount = 264;

Console.WriteLine(b1.Name);
Console.WriteLine(b1.PageCount);
Console.WriteLine(b1.Description);
