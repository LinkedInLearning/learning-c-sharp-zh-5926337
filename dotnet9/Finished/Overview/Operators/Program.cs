using System;


// 声明一些变量来练习运算符的使用
int x = 10, y = 5;
string a = "abcd", b = "efgh";

// 基本数学运算符 +, -, /, *
Console.WriteLine("----- Basic Math -----");
Console.WriteLine((x / y) * x);
Console.WriteLine(a + b);

// 增量和减量运算符 ++, --
Console.WriteLine("----- Shorthand -----");

// TODO: 后缀递增和递减运算符。x++ 和 x-- 会先返回 x 的值，然后再递增或递减 x
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);

// TODO: 前缀递增和递减运算符。++x 和 --x 会先递增或递减 x，然后再返回 x


// 加法赋值运算符 a = a + b 可以写成 a += b
a += b;
Console.WriteLine(a);

// 减法赋值运算符 a = a - b 可以写成 a -= b
x -= y;
Console.WriteLine(x);

// 逻辑运算符 && 和 ||
Console.WriteLine("----- Logic Operators -----");
Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);

// null-coalescing operators
string str = null;
// the ?? operator uses left operand if not null, or right one if it is
Console.WriteLine(str ?? "Unknown string");

// the ??= operator assigns the right operand if the left one is null
// it replaces the code:
// if (variable is null) {
//    variable = somevalue;
// }
str ??= "New string";
Console.WriteLine(str);
