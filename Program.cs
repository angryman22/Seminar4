// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Цикл for

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= A; i++)
// {
//     sum +=i;
// }
// Console.WriteLine($"Сумма элементов от одного до {A} = {sum}");

// Через метод и Цикл while


// int MethodSumm ( int number)
// {
//     int sum = 0;
//     int start = 1;
//     while (start <= number)
//     {
//         sum += start;
//         start++;
//     }
//     return sum;
// }
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма элементов от одного до {A} = {MethodSumm(A)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Res = number;
// int count = 0;
// while (Res != 0)
// {
//     Res = Res / 10;
//     count++;
// }
// Console.WriteLine(count);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int fact = 1;
// for (int i = 2; i <= N; i++)
// {
//     fact = fact*i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {N} равно {fact}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] nums = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     nums [i] = new Random().Next(2);
//     Console.Write($"{nums [i]} ");
// }
// Console.WriteLine(nums);

// Вариант с методом

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size]; // size = 5; result = [0,0,0,0,0]
//     for (int i = 0; i < result.Length; i++) // size = result.Length
//     {
//         //[min; max+1);
//         result[i] = new Random().Next(2); //Если указано одно число, то вы идете от 0 до этого числа
//     }
//     return result;
// }

// int [] testArray = GetBinaryArray(8);
// Console.WriteLine($"Результат: [ {String.Join("; ", testArray)} ]");



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = numberA;
// for (int i = 1; i < numberB; i++)
// {
//     result *= numberA;
// }
// Console.WriteLine("Число " + numberA + " в степени " + numberB + " равно " + result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numLength = 0;
int result = 0;
int res = Convert.ToInt32(number);
while (res != 0)
{
    int ost = res %10;
    result += ost;
    res = res / 10;
}

Console.WriteLine("Сумма цифр в числе " + number + " равна " + result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] nums = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     nums [i] = new Random().Next();
//     Console.Write($"{nums [i]} ");
// }