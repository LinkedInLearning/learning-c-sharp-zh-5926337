namespace Comments;

class Program
{
  /// <summary>
  /// 这是应用程序的入口点
  /// </summary>
  /// <param name="args">命令行参数列表</param>
  /// <returns>无返回值</returns>
  static void Main(string[] args)
  {
    // 单行注释以两个斜杠开头
    // 你可以有任意多的单行注释
    Console.WriteLine("Hello World!");

    /* 多行注释以斜杠和星号开头
    可以持续多行
    直到遇到星号和斜杠 */
    Console.WriteLine("Hello World!");
  }
}
