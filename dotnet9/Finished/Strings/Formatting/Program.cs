int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { .386, .413, .421, .457 };
string str1 = "TestStr";
int value1 = 1234;
decimal value2 = 1234.5678m;

// 基本格式化信息
Console.WriteLine("{0}", str1);

// 指定数字格式
// 基本格式是 {index[,alignment]:[format]}
// 常用类型：N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", value1);
Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", value2);

// 添加一个数字来指定精度
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", value1);

// 在格式化字符串中添加对齐和间距
Console.WriteLine("季度销售额数据：");
Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);
Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);
Console.WriteLine("国际销售占比数据：");
Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}", intlMixPct[0], intlMixPct[1], intlMixPct[2], intlMixPct[3]);
