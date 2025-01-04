// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the time in seconds:");
int totalSeconds = int.Parse(Console.ReadLine());

// 实现你的逻辑
int hours = totalSeconds / 3600;
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine("{0} hour(s), {1} minute(s), and {2} second(s)", hours, minutes, seconds);
// 你也可以使用下面的方式输出，这是字符串插值的写法，我们会在后面的章节中详细讲解
// Console.WriteLine("{0} hour(s), {1} minute(s), and {2} second(s)", hours, minutes, seconds);


