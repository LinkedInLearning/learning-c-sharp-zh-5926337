// Tuple 是一种组合值的数据结构，可以将多个值组合在一起，从 C# 7 开始引入
(int a, int b) tup1 = (5, 10);
var tup2 = ("Hello", 3.14);

// Tuple 可以包含多个值
(int price, int quantity, string name) tup3 = (10, 5, "Apple");

// Tuple 值是可变的
tup1.b = 20;
tup2.Item1 = "你好";

Console.WriteLine($"{tup1.a}, {tup1.b}");
Console.WriteLine($"{tup2.Item1},{tup2.Item2}");
Console.WriteLine($"{tup3.price}, {tup3.quantity}, {tup3.name}");

// 函数可以使用元组返回多个值
(int sum, int product) PlusTimes(int a, int b)
{
    return (a + b, a * b);
}

// 调用函数并获取元组的值
(int, int) result = PlusTimes(6, 12);
Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");
var result2 = PlusTimes(8, 15);
Console.WriteLine($"Sum: {result2.sum}, Product: {result2.product}");


