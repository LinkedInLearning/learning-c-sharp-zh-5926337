using System;



int theVal = 50;

// if-else 
if (theVal == 50)
{
    Console.WriteLine("theVal 是 50");
}
else if (theVal >= 51 && theVal <= 60)
{
    Console.WriteLine("theVal 处于 51 和 60 之间");
}
else
{
    Console.WriteLine("theVal 不是 50");
}

// -----------------------
// 使用三元条件运算符 ?:

// 一个只有两种情况的 if-then
if (theVal < 50)
{
    Console.WriteLine("theVal 比较小");
}
else
{
    Console.WriteLine("theVal 比较大");
}

// 上面的代码可以被替换为使用三元条件运算符 ?:
Console.WriteLine(theVal < 50 ? "theVal 比较小" : "比较大");


