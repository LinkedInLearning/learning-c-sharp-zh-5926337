using System;

// 设置当前线程的区域性为中文
System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");

// 声明一些变量
string make = "Mercedes-Benz";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

// Output information using formatting
Console.WriteLine("这辆车是 {0} {1} {2}, 已行驶 {3} 公里， 价格是 ￥{4}",
    year, make, model, miles, price);

// 使用字符串插值
Console.WriteLine($"这辆车是 {year} {make} {{{model}}}, 已行驶 {miles} 英里，价格是 {price:C2}");

// 使用内联表达式
Console.WriteLine($"这辆车是 {year} {make} {{{model}}}, 已行驶 {miles * 1.6:F2} 公里，价格是 {price:C2}");
