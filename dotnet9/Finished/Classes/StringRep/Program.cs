using StringRep;

// 所有类都继承自 Object，这意味着每个类都继承 ToString() 方法
int x = 1000;
Console.WriteLine(x.ToString());

// 如果不重写该方法，那么默认行为只是打印类的名称和命名空间
object a = new object();
Console.WriteLine(a.ToString());

Book b1 = new Book("活着", "余华", 191);
Console.WriteLine(b1.ToString());
Console.WriteLine(b1);

Console.WriteLine(b1.ToString('B'));
Console.WriteLine(b1.ToString('F'));
