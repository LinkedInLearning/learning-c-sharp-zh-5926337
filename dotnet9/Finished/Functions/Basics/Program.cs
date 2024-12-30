// 函数用于将可重用代码组合在一起，形成一个可以使用参数自定义的单元。

// 函数有返回类型、名称和可选参数
float MilesToKilometers(float miles)
{
    float result = miles * 1.60934f;
    return result;
}

// 如果函数没有返回值，则返回类型为 'void'
void PrintWithPrefix(string value)
{
    Console.WriteLine($"::> {value}");
}

// 调用第一个函数
Console.WriteLine($"8 英里等于 {MilesToKilometers(8f):F2} 公里");
Console.WriteLine($"52 英里等于 {MilesToKilometers(52f):F2} 公里");

// 调用第二个函数
PrintWithPrefix("测试字符串");
PrintWithPrefix("另一个测试字符串");
