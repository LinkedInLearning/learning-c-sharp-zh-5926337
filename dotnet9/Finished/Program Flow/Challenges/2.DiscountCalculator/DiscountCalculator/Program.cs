// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 在下面实现你的逻辑

Console.WriteLine("请输入购买金额：");
// 对涉及到货币的计算，建议使用 decimal 类型
// 用 decimal.Parse 方法将用户输入的字符串转换为 decimal 类型
var amount = decimal.Parse(Console.ReadLine());
var discount = 0.0m;

if (amount >= 500)
{
  discount = amount * 0.2m; // 20% 折扣
}
else if (amount >= 200)
{
  discount = amount * 0.1m; // 10% 折扣
}
// 小于 200 时，折扣为 0，不需要处理

var finalAmount = amount - discount;
// 输出结果
Console.WriteLine("折扣金额：{0}", discount);
Console.WriteLine("最终支付金额：{0}", finalAmount);