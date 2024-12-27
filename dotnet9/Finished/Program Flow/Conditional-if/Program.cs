int value = 50;

// if-else 
if (value == 50)
{
    Console.WriteLine("value 是 50");
}
else if (value >= 51 && value <= 60)
{
    Console.WriteLine("value 处于 51 和 60 之间");
}
else
{
    Console.WriteLine("value 不是 50");
}

// -----------------------
// 使用三元条件运算符 ?:

// 一个只有两种情况的 if-then
// if (value < 50)
// {
//     Console.WriteLine("value 比较小");
// }
// else
// {
//     Console.WriteLine("value 比较大");
// }

// 上面的代码可以被替换为使用三元条件运算符 ?:
Console.WriteLine(value < 50 ? "value 比较小" : "value 比较大");


