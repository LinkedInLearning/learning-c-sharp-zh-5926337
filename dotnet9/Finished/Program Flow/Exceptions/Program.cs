using System;


int x = 100;
int y = 10;
int result;

try
{
    if (x > 1000)
    {
        throw new ArgumentOutOfRangeException("x", "x 必须小于或等于 1000。");
    }
    result = x / y;
    Console.WriteLine("结果是: {0}", result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("出错了！你不能除以 0。");
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("抱歉, x 的值不能超过 1000！");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("这段代码始终会执行。");
}
