// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

int highestMath = 0, lowestMath = 100, highestChinese = 0, lowestChinese = 100, highestEnglish = 0, lowestEnglish = 100;
string highestMathStudent = "", lowestMathStudent = "", highestChineseStudent = "", lowestChineseStudent = "", highestEnglishStudent = "", lowestEnglishStudent = "";
StringBuilder report = new StringBuilder();

report.AppendLine("学生成绩单\n");

// 使用制表符输出表头
report.AppendLine("姓名\t数学\t语文\t英语\t总分\t平均分");

// 使用字符串插值输入表头。负数间距表示左对齐，正数间距表示右对齐
//report.AppendLine($"{"姓名",-10}{"数学",-10}{"语文",-10}{"英语",-10}{"总分",-10}{"平均分",-10}\n");

Console.WriteLine("请输入学生姓名和成绩，格式为 姓名 数学成绩 语文成绩 英语成绩，或 'end' 结束");
while (true)
{
    var input = Console.ReadLine();

    // 如果输入为 end 则结束循环
    if (input.ToLower().Equals("end"))
    {
        break;
    }

    // 验证输入
    string[] parts = input.Split(' ');
    if (parts.Length != 4 || !int.TryParse(parts[1], out int math) || !int.TryParse(parts[2], out int chinese) ||
        !int.TryParse(parts[3], out int english)
        || math < 0 || math > 100 || chinese < 0 || chinese > 100 || english < 0 || english > 100)
    {
        Console.WriteLine("输入不正确，请重新输入");
        continue;
    }

    // 计算总分和平均分
    int total = math + chinese + english;
    double average = Math.Round(total / 3.0, 2);

    // 计算各科目的最高分和最低分
    if (math > highestMath)
    {
        highestMath = math;
        highestMathStudent = parts[0];
    }

    if (math < lowestMath)
    {
        lowestMath = math;
        lowestMathStudent = parts[0];
    }

    if (chinese > highestChinese)
    {
        highestChinese = chinese;
        highestChineseStudent = parts[0];
    }

    if (chinese < lowestChinese)
    {
        lowestChinese = chinese;
        lowestChineseStudent = parts[0];
    }

    if (english > highestEnglish)
    {
        highestEnglish = english;
        highestEnglishStudent = parts[0];
    }

    if (english < lowestEnglish)
    {
        lowestEnglish = english;
        lowestEnglishStudent = parts[0];
    }

    // 使用制表符输出学生信息
    report.AppendLine($"{parts[0]}\t{math}\t{chinese}\t{english}\t{total}\t{average}");

}

report.AppendLine();

// 输出各科目的最高分和最低分
report.AppendLine($"数学最高分：{highestMathStudent} {highestMath}");
report.AppendLine($"数学最低分：{lowestMathStudent} {lowestMath}");
report.AppendLine($"语文最高分：{highestChineseStudent} {highestChinese}");
report.AppendLine($"语文最低分：{lowestChineseStudent} {lowestChinese}");
report.AppendLine($"英语最高分：{highestEnglishStudent} {highestEnglish}");
report.AppendLine($"英语最低分：{lowestEnglishStudent} {lowestEnglish}");

// 输出报告
Console.WriteLine(report.ToString());