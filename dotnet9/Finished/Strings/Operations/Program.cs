// 声明一些字符串变量
string outstr;
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = ["one", "two", "three", "four"];

// 获取字符串的长度
Console.WriteLine(str1.Length);

// 获取字符串中的字符
Console.WriteLine(str1[14]);

// 像处理任何其他值序列一样迭代字符串
foreach (char c in str1)
{
    Console.Write(c);
    if (c == 'b')
    {
        Console.WriteLine();
        break;
    }
}

// 字符串连接
outstr = string.Concat(strs);
Console.WriteLine(outstr);

// 使用 Join 方法连接字符串
outstr = string.Join('.', strs);
Console.WriteLine(outstr);
outstr = string.Join("---", strs);
Console.WriteLine(outstr);

// 字符串比较
// Compare 方法比较字符串会执行一个序数比较并返回：
// < 0 : 第一个字符串在排序顺序中排在第二个字符串之前
// 0 : 第一个和第二个字符串在排序顺序中的位置相同
// > 0 : 第一个字符串在排序顺序中排在第二个字符串之后
int result = string.Compare(str2, "This is a string");
Console.WriteLine(result);

// Equals 方法只返回一个普通的布尔值
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

// 字符串搜索: IndexOf 和 LastIndexOf 方法
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("the"));

// 字符串替换: Replace 方法
outstr = str1.Replace("fox", "cat");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("fox"));
