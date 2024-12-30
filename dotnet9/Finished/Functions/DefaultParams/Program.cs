// 函数可以为其参数提供默认值
void PrintWithPrefix(string value, string prefix = "")
{
    Console.WriteLine($"{prefix} {value}");
}

// 使用默认参数
PrintWithPrefix("你好！");
PrintWithPrefix("你好！", ">: ");

// 使用命名参数
PrintWithPrefix(prefix: "% ", value: "你好！");
