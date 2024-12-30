using System.Text;

// 创建一个 StringBuilder
StringBuilder sb = new StringBuilder("Initial String. ", 200);
int jumpCount = 10;
string[] animals = ["goats", "cats", "pigs"];

// 打印一些关于 StringBuilder 的基本统计信息
Console.WriteLine($"容量: {sb.Capacity}; 长度: {sb.Length}");

// 使用 Append 方法向 builder 添加一些字符串
sb.Append("The quick brown fox ");
sb.Append("jumps over the lazy dog.");

// AppendLine 方法可以添加一个换行符
sb.AppendLine();

// AppendFormat 方法可以用来添加格式化的字符串
sb.AppendFormat("He did this {0} times.", jumpCount);
sb.AppendLine();

// AppendJoin 方法可以迭代一组值
sb.Append("He also jumped over ");
sb.AppendJoin(",", animals);

// 使用 Replace 方法修改内容
sb.Replace("fox", "cat");

// 使用 Insert 方法在任意索引处插入内容
sb.Insert(0, "This is the ");

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

// 转换为一个字符串
Console.WriteLine(sb.ToString());
