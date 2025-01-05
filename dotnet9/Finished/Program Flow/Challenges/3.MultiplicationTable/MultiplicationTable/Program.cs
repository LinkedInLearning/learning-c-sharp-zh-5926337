// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 9; i++) // 外层循环控制行数
{
  for (int j = 1; j <= i; j++) // 内层循环控制每行的列数
  {
    Console.Write("{0} * {1} = {2}\t", j, i, i * j); // 输出乘法表达式，用 \t 对齐
  }
  Console.WriteLine(); // 每行结束换行
}