// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 3;
int res = 1;

while (res < num)
{

    double result = Math.Pow(res, index);
    Console.Write(result + "  ");
    res++;
}



