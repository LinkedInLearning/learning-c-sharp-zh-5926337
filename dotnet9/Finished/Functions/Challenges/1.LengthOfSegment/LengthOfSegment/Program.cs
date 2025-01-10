// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 定义一个函数，用于计算两点之间的距离
double CalculateDistance(double x1, double y1, double x2, double y2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double distance = Math.Sqrt(x * x + y * y);
    // 保留两位小数
    return Math.Round(distance, 2);
}

// 定义一个函数来验证用户输入的是否是数字。如果不是，提示用户重新输入
double GetNumberFromUser(string prompt)
{
    double number;
    while (true)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();
        var isNumber = double.TryParse(input, out number);
        if (isNumber)
        {
            break;
        }

        Console.WriteLine("输入的不是数字，请重新输入！");
    }

    return number;
    // 也可以使用do-while循环
    //do
    //{
    //    Console.WriteLine(prompt);
    //    string input = Console.ReadLine();
    //    var isNumber = double.TryParse(input, out number);
    //    if (!isNumber)
    //    {
    //        Console.WriteLine("输入的不是数字，请重新输入！");
    //    }
    //} while (!isNumber);
    //return number;
}


// 主程序
double x1 = GetNumberFromUser("请输入第一个点的横坐标：");
double y1 = GetNumberFromUser("请输入第一个点的纵坐标：");
double x2 = GetNumberFromUser("请输入第二个点的横坐标：");
double y2 = GetNumberFromUser("请输入第二个点的纵坐标：");
// 调用函数计算两点之间的距离
double distance = CalculateDistance(x1, y1, x2, y2);
// 输出结果
Console.WriteLine($"两点之间的距离是：{distance}");
