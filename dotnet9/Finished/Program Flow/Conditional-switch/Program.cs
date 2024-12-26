using System;


int theVal = 50;

// 使用 switch 语句
switch (theVal)
{
    case 50:
        Console.WriteLine("theVal 的值是 50");
        break;
    case 51:
        Console.WriteLine("theVal 的值是 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("theVal 的值在 52 和 54 之间");
        break;
    default:
        Console.WriteLine("theVal 的值不在 50 到 54 之间");
        break;
}

