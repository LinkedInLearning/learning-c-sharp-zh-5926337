using System;


int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

Console.WriteLine("Using break and continue :");
foreach (int val in values)
{
    // continue 语句跳过循环的剩余部分，直接进入下一次迭代
    if (val >= 20 && val <= 29)
    {
        continue;
    }

    Console.WriteLine($"val 的值是 {val}");

    // break 语句会终止循环并退出
    if (val >= 40)
    {
        break;
    }
}
