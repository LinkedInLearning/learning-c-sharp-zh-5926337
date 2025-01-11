// See https://aka.ms/new-console-template for more information
using InheritanceSample;

Console.WriteLine("Hello, World!");

// 创建学生和老师对象
Student student = new Student("张三", new DateTime(2000, 1, 15), "S12345", "计算机科学", 3);
Teacher teacher = new Teacher("李四", new DateTime(1980, 2, 20), "T67890", "教授", "计算机系");

// 调用学生和老师的方法
Console.WriteLine(student);
student.Study("C# 编程");

Console.WriteLine(teacher);
teacher.Teach("C# 编程");