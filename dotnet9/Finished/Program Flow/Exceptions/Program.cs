int x = 100;
int y = 10;
int result;

// try-catch 表达式使错误检查更容易
try
{
    if (x > 1000)
    {
        throw new ArgumentOutOfRangeException(nameof(x), "x 必须小于或等于 1000");
    }
    result = x / y;
    Console.WriteLine("结果是: {0}", result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("发生了一个错误");
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("抱歉, x 的值不能超过 1000");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("这段代码始终会执行");
}
