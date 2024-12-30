// 一般的值参数不能被函数修改，因为它们是原始值的副本
void TestFunc1(int arg1)
{
    arg1 += 10;
    Console.WriteLine($"在 TestFunc1 内部：{arg1}");
}


// 以引用方式传递的参数可以被函数修改，并反映到调用者
void TestFunc2(ref int arg1)
{
    arg1 += 10;
    Console.WriteLine($"在 TestFunc2 内部：{arg1}");
}


// out 关键字表示参数返回一个值，而不是用于向函数提供数据
void PlusTimes(int arg1, int arg2, out int sum, out int product)
{
    sum = arg1 + arg2;
    product = arg1 * arg2;
}


int value1 = 10;
int value2 = 20;

// 函数通常不会修改值参数
Console.WriteLine($"调用 TestFunc1 前：{value1}");
TestFunc1(value1);
Console.WriteLine($"调用 TestFunc1 后：{value1}");

// 通过引用传递参数，函数可以修改它们
Console.WriteLine($"调用 TestFunc2 前：{value1}");
TestFunc2(ref value1);
Console.WriteLine($"调用 TestFunc2 后：{value1}");


// out 参数可以指明参数是用于返回值，而不是输入
int sum, product;
PlusTimes(value1, value2, out sum, out product);
Console.WriteLine($"和是 {sum}, 积是 {product}");
