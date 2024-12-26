using System;


string inputStr = "";

// while 循环的基本结构是在门控条件为真时执行
Console.WriteLine("使用 while 循环:");
while (inputStr != "exit")
{
    inputStr = Console.ReadLine();

    Console.WriteLine("你输入了: {0}", inputStr);
}
Console.WriteLine();

// do-while 循环总是至少执行一次
Console.WriteLine("使用 do-while() 循环:");
do
{
    inputStr = Console.ReadLine();

    Console.WriteLine("你输入了: {0}", inputStr);
} while (inputStr != "exit");
Console.WriteLine();

