// 声明一些基本的值类型变量
int i = 10;
float f = 2.0f;
double db = 20.0d;
decimal d = 10.0m;
bool b = true;
char c = 'c';

// 声明一个字符串 - 它是一个字符的集合
string str = "a string";

// 声明一个隐式变量
var x = 10;
var z = "Hello!";

// TODO: 声明一个数组变量
int[] vals = new int[5];
//int[] vals = [1, 2, 3, 4, 5];
string[] strs = ["one", "two", "three"];

// TODO: 使用格式化字符串打印值
Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", i, f, db, d, b, c, str, x, z);

// TODO: “null” 表示“没有值”
object obj = null;
Console.WriteLine(obj);

// TODO: 类型的隐式转换
long bigNumber;
bigNumber = i;

// TODO: 类型的显式转换
float i_to_f = (float)i;
Console.WriteLine("{0}", i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}", f_to_i);
