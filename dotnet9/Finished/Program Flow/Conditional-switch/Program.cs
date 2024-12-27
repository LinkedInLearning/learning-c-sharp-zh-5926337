int value = 50;

// 使用 switch 语句
switch (value)
{
    case 50:
        Console.WriteLine("value 的值是 50");
        break;
    case 51:
        Console.WriteLine("value 的值是 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("value 的值在 52 和 54 之间");
        break;
    case int n when (n >= 55 && n <= 60):
        Console.WriteLine("value 的值在 55 和 60 之间");
        break;
    default:
        Console.WriteLine("value 的值不在 50 到 60 之间");
        break;
}

