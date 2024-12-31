using Modifiers;

// 创建一个新的 Book 实例
Book b1 = new Book("活着", "余华", 219);

// 在上一个示例中，这是不允许的，但如果字段 name 被声明为 public，则可以运行
b1._name = "许三观卖血记";
Console.WriteLine(b1.GetDescription());

// TODO: 使用方法设置数据，而不是直接访问字段


