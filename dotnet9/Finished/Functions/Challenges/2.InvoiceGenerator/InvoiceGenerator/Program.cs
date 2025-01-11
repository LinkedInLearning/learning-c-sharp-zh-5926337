// See https://aka.ms/new-console-template for more information
using System.Globalization;

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
(decimal, decimal, decimal, decimal) CalculateTotalPayment((string product, int quantity, decimal price)[] items, bool includeTax = true)
{
    var totalAmount = 0m;
    var totalDiscount = 0m;
    var totalTax = 0m;

    // 计算总价
    foreach (var item in items)
    {
        totalAmount += item.quantity * item.price;
    }

    // 计算折扣
    if (totalAmount >= 500)
    {
        totalDiscount = totalAmount * 0.2m; // 20% 折扣
    }
    else if (totalAmount >= 200)
    {
        totalDiscount = totalAmount * 0.1m; // 10% 折扣
    }

    // 计算税
    if (includeTax)
    {
        totalTax = (totalAmount - totalDiscount) * 0.1m; // 10% 税
    }

    // 计算总付款
    var totalPayment = totalAmount - totalDiscount + totalTax;

    // 返回 Tuple 对象
    return (totalAmount, totalDiscount, totalTax, totalPayment);
}

// 调用方法计算总付款
var (total, discount, tax, payment) = CalculateTotalPayment(products);

// 输出发票信息
Console.WriteLine("发票信息");
Console.WriteLine();
Console.WriteLine("商品\t数量\t单价");
foreach (var item in products)
{
    Console.WriteLine($"{item.product}\t{item.quantity}\t{item.price:C}");
}
Console.WriteLine();
Console.WriteLine($"总价:\t{total:C}");
Console.WriteLine($"折扣:\t{discount:C}");
Console.WriteLine($"税:\t{tax:C}");
Console.WriteLine($"总付款:\t{payment:C}");