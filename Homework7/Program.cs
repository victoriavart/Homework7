/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] a = new double[3, 4];

Random random = new Random();
for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 4; n++)
    {
        a[m, n] = random.NextDouble()*10;
        Console.Write("{0,6:F2}", a[m, n]);
    }
    Console.WriteLine();
}
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
 */

/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int [,] a = new int[4, 4];
double average = new double();
Random random = new Random();

for (int i = 0; i  < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.Next(1,10);
        Console.Write("{0}\t", a[i, j]);
    }
    Console.WriteLine();
}


for (int j = 0; j < 4; j++) 
{

    {
        double summ = new double();
        for (int i = 0; i < 4; i++)
        {
        summ += a[i, j];
        average = summ / 4;
        }

    Console.Write(average); 
    }
    Console.WriteLine();
}
*/