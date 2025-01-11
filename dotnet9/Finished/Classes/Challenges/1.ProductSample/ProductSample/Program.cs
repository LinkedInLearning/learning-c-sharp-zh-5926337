// See https://aka.ms/new-console-template for more information

using ProductSample;

Console.WriteLine("Hello, World!");

// 创建商品对象
var product = new Product("笔记本电脑", "电子产品", "ThinkPad X1 Carbon", 7999, 100);
Console.WriteLine(product.ToString());

// 销售商品
product.Sell(10);
Console.WriteLine(product.ToString());

// 进货商品
product.Restock(20);
Console.WriteLine(product.ToString());