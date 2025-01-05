// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 在下面实现你的逻辑

// 生成一个 1 到 100 之间的随机数
Random random = new Random();
int target = random.Next(1, 101);
int guessCount = 0;
int guess = 0;

Console.WriteLine("猜数字游戏开始！");

while (true)
{
  Console.Write("请猜一个 1 到 100 之间的数字：");
  string input = Console.ReadLine();

  // 验证输入是否为合法数字
  try
  {
    guess = int.Parse(input);
  }
  catch (FormatException)
  {
    Console.WriteLine("输入无效，请输入一个数字。");
    continue;
  }

  guessCount++;

  // 判断猜测结果
  if (guess > target)
  {
    Console.WriteLine("太大了，请再试一次。");
  }
  else if (guess < target)
  {
    Console.WriteLine("太小了，请再试一次。");
  }
  else
  {
    Console.WriteLine("恭喜你，猜对了！你一共猜了 {0} 次。", guessCount);
    break;
  }
}