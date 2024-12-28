int myVal = 15;
int[] numbers = [3, 14, 15, 92, 6];
string str = "The quick brown fox jumps over the lazy dog";

// 使用 for 循环
Console.WriteLine("使用 for 循环:");
for (int i = 0; i < myVal; i++)
{
    Console.WriteLine("现在 i 的值是 {0}", i);
}
Console.WriteLine();

// foreach-in 循环可以用来遍历序列
Console.WriteLine("使用 foreach 循环:");
foreach (int number in numbers)
{
    Console.WriteLine("现在 i 的值是 {0}", number);
}

// 计算字符串中字母 o 的个数
var count = 0;
foreach (char c in str)
{
    if (c == 'o')
    {
        count++;
    }
}
Console.WriteLine("字母 'o' 出现了 {0} 次。", count);

