# 学生成绩单系统

## 题目

设计一个学生成绩单系统，要求实现以下功能：

1. 输入学生信息和成绩
   要求用户输入多个学生的姓名和成绩，每个学生的信息包括姓名、数学成绩、语文成绩和英语成绩。程序可以接受多个学生信息，直到用户输入 `end` 为止。
2. 计算总成绩和平均成绩
   对每个学生，计算他们的总成绩和平均成绩，四舍五入保留两位小数。
3. 输出成绩单
   根据输入的学生信息，生成一份成绩单，包含每个学生的姓名、数学成绩、语文成绩、英语成绩、总成绩和平均成绩。
4. 输出每个科目的最高成绩和最低成绩
   输出所有学生中数学、语文、英语的最高成绩和最低成绩，以及对应的学生姓名。
5. 输入数据验证
   对于每个输入的成绩，需要验证其是否为一个合法的数字（0 到 100 之间），如果输入无效，提示用户重新输入。

## 输入输出示例

### 输入

```plaintext
张三 80 90 70
李四 85 88 92
王五 90 95 100
end
```

### 输出

```plaintext
学生成绩单：

姓名  数学  语文  英语  总分  平均分
张三  80    90   70   240   80.00
李四  85    88   92   265   88.33
王五  90    95   100  285   95.00

数学最高分：王五 90
数学最低分：张三 80
语文最高分：王五 95
语文最低分：李四 88
英语最高分：王五 100
英语最低分：张三 70
```

## 提示

* 可以使用 `while (true)` 循环来实现多次输入学生信息的过程，直到用户输入 `end` 为止。
* 使用 `string.Split` 方法来分割输入的字符串，例如：
  
  ```csharp
  string input = "张三 80 90 70";
  string[] parts = input.Split(' ');
  string name = parts[0];
  int math = int.Parse(parts[1]);
  int chinese = int.Parse(parts[2]);
  int english = int.Parse(parts[3]);
  ```

* 使用 `double.ToString("F2")` 方法将一个 `double` 类型的数字保留两位小数，例如：
  
  ```csharp
  double average = 80.0;
  string averageText = average.ToString("F2"); // "80.00"
  ```

  或者你也可以使用 `Math.Round` 方法来实现四舍五入：

  ```csharp
  double average = 80.0;
  string averageText = Math.Round(average, 2).ToString(); // "80.00"
  ```

* 使用 `StringBuilder` 类来拼接字符串。
* 使用字符串插值来格式化输出，并添加间距和对齐。有几种方式可以实现：
  * 使用制表符 `\t` 来对齐字符串，例如：

    ```csharp
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    string line = $"{name}\t{math}\t{chinese}\t{english}";
    ```

    使用制表符可以避免手动计算中文字符的宽度，但如果字符宽度不一致，可能会导致对齐不准确。
  
  * 使用 `string.PadRight` 或 `string.PadLeft` 方法来对齐字符串，例如：

    ```csharp
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    string line = $"{name.PadRight(10)}{math.PadRight(10)}{chinese.PadRight(10)}{english.PadRight(10)}";
    ```
  
  * 使用字符串插值的格式化功能，例如：

    ```csharp
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    string line = $"{name,-10}{math,-10}{chinese,-10}{english,-10}";
    ```
  
  * 使用 `string.Format` 方法，例如：

    ```csharp
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    string line = string.Format("{0,-10}{1,-10}{2,-10}{3,-10}", name, math, chinese, english);
    ```
  
  * 使用 `StringBuilder.AppendFormat` 方法，例如：

    ```csharp
    StringBuilder builder = new StringBuilder();
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    builder.AppendFormat("{0,-10}{1,-10}{2,-10}{3,-10}", name, math, chinese, english);
    ```
  
  * 或者你也可以直接使用 `Console.WriteLine` 方法输出，例如：

    ```csharp
    string name = "张三";
    string math = "80";
    string chinese = "90";
    string english = "70";
    Console.WriteLine($"{name,-10}{math,-10}{chinese,-10}{english,-10}");
    ```

  以上几种方法在输出纯英文字符时效果较好，但对于中文字符可能会出现对齐不准确的情况，可以根据实际情况选择合适的方式。