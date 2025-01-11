// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 设置当前线程的区域为中国
Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");

// 创建一个商品列表
var products = new (string product, int quantity, decimal price)[]
{
    ("苹果", 10, 1.2m),
    ("香蕉", 5, 0.5m),
    ("橙子", 3, 2.5m),
};

// 创建一个计算总付款的方法


// 调用方法计算总付款


// 输出发票信息