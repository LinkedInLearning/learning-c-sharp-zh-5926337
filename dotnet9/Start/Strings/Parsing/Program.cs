string numString1 = "1";
string numString2 = "2.00";
string numString3 = "3,000";
string numString4 = "3,000.00";

// 在这个例子里，Parse 方法尝试将字符串解析为数字，但可能会引发异常，因此我们需要捕获异常
int targetNumber;
try
{
    // TODO: 使用 Parse 方法尝试解析一个简单的整数

    // TODO: 使用 Parse 方法尝试解析一个浮点数。
    // 这只有在小数值为 0 时才有效

    // TODO: 使用 Parse 方法尝试解析一个带有千位分隔符的数字

    // TODO: 使用 Parse 方法尝试解析一个带有千位分隔符和小数点的数字

    // TODO: 这种方法也适用于其他类型，比如布尔值

    // TODO: 或用来解析浮点数

}
catch
{
    Console.Write("转换失败");
}

// TODO: TryParse 方法类似，但会处理异常
bool succeeded = false;
if (succeeded)
{
    //Console.WriteLine($"{targetNumber}");
}

