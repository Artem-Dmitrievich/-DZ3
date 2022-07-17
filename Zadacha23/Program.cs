//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//1 способ решения (как на уроке)
//Console.Write("Число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//    Console.Write(i * i * i + " ");

//2 способ решения
Console.WriteLine("Число: ");
int a = Convert.ToInt32(Console.ReadLine());
int stepen = 3;
for (int i = 1; i <= a; i++)
{
    Console.Write(Math.Pow(i, stepen) + " ");
}
