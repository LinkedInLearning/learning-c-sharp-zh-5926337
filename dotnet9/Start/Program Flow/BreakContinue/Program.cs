int[] values = [15, 7, 12, 23, 41, 28, 9, 17, 36];

Console.WriteLine("使用 break 和 continue:");
foreach (int value in values)
{
    // TODO: continue 语句跳过循环的剩余部分，直接进入下一次迭代
    if (value >= 20 && value <= 29)
    {
        continue;
    }
    Console.WriteLine($"value 的值是 {value}");

    // TODO: break 语句会终止循环并退出
    // if (value >= 40)
    // {
    //     break;
    // }
}

