using Modifiers;

// 创建一个新的 Book 实例
Book b1 = new Book("活着", "余华", 219);

b1._name = "许三观卖血记";
Console.WriteLine(b1.GetDescription());

// 使用方法设置数据，而不是直接访问字段
b1.SetName("围城");
b1.SetAuthor("钱钟书");
b1.SetPageCount(359);
Console.WriteLine(b1.GetDescription());
