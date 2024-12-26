using System;
using System.Globalization;


string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

// 在这个例子里，Parse 方法尝试将字符串解析为数字，但可能会引发异常，因此我们需要捕获异常
int targetNum;
try
{
    // 使用 Parse 方法尝试解析一个简单的整数
    targetNum = int.Parse(numStr1);
    Console.WriteLine($"{targetNum}");

    // 使用 Parse 方法尝试解析一个浮点数。
    // 这只有在小数值为 0 时才有效
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    Console.WriteLine($"{targetNum}");

    // 使用 Parse 方法尝试解析一个带有千位分隔符的数字
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    Console.WriteLine($"{targetNum}");

    // 使用 Parse 方法尝试解析一个带有千位分隔符和小数点的数字
    targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
    Console.WriteLine($"{targetNum}");

    // 这种方法也适用于其他类型，比如布尔值
    Console.WriteLine($"{bool.Parse("True")}");

    // 或用来解析浮点数
    Console.WriteLine($"{float.Parse("1.235"):F2}");
}
catch
{
    Console.Write("Conversion failed");
}

// TryParse 方法类似，但会处理异常
bool succeeded = false;
succeeded = Int32.TryParse(numStr1, out targetNum);
if (succeeded)
{
    Console.WriteLine($"{targetNum}");
}

