// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 在下面实现你的逻辑
Console.WriteLine("Enter a year:");
var year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
  Console.WriteLine("{0} is a leap year.", year);
}
else
{
  Console.WriteLine("{0} is not a leap year.", year);
}