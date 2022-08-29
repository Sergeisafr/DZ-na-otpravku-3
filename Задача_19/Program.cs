Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num % 10; // показывает пятую цифру 
int b = (num / 10) % 10; // показывает четвертую цифру
int c = (num / 1000) % 10; // показывает вторую цифру
int d = (num / 10000) % 10; // показывает первую цифру
if (a == d && c == b)
{Console.WriteLine( (num) + ", является палиндром");}
else
{Console.WriteLine( (num) + ", не является палиндромом");}
