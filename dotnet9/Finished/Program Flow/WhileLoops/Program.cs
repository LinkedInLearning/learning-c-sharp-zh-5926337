string inputValue = "";

// while 循环的基本结构是在条件为真时执行
Console.WriteLine("使用 while 循环:");
while (inputValue != "exit")
{
    inputValue = Console.ReadLine();
    Console.WriteLine("你输入了: {0}", inputValue);
}
Console.WriteLine();

// do-while 循环总是至少执行一次
Console.WriteLine("使用 do-while() 循环:");
do
{
    inputValue = Console.ReadLine();
    Console.WriteLine("你输入了: {0}", inputValue);
} while (inputValue != "exit");


