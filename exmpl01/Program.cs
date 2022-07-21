// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// строки и массивы использовать нельзя

Console.WriteLine("Введите пятизначное число: ");
int inpt = Convert.ToInt32(Console.ReadLine());

int x5 = inpt % 10;
int x4 = inpt / 10 % 10;
int x3 = inpt / 100 % 10;
int x2 = inpt / 1000 % 10;
int x1 = inpt / 10000 % 10;

if (x5 == x1 & x4 == x2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}


/*Console.WriteLine("Введите пятизначное число: "); // можно не пятизначное
String str = Console.ReadLine();
Console.WriteLine("Вы ввели число " + str);

int len = str.Length;
int lenMid = len / 2;
int res = 0;

while (res <= lenMid)
{
    string i = str.Substring(res, 1);
    int nullToNext = Convert.ToInt32(i);
    string j = str.Substring(len - 1, 1);
    int NextToNull = Convert.ToInt32(j);

    if (nullToNext == NextToNull)
    {
        res++;
        len--;
        Console.WriteLine("Число является палиндромом");
    }

    else
        Console.WriteLine("Число не является палиндромом");
    break;
}
*/
