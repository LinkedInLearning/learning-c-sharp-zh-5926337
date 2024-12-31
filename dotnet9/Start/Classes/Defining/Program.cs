// TODO: 创建新的对象实例，使用 "new" 操作符
using Defining;

Book b1 = new Book("战争与和平", "列夫·托尔斯泰", 1225);
Book b2 = new Book("活着", "余华", 219);

// TODO: 调用对象上的方法
Console.WriteLine(b1.GetDescription());
Console.WriteLine(b2.GetDescription());

// TODO: 尝试设置其中一个属性 -- 这将导致错误
//b2._name = "许三观卖血记";
