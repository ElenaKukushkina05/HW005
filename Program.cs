
// Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345,897,568,234] -> 2


// int[] GetArray (int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];
//     for (int i = 0; i < resultArray.Length; i++) 
//     {
//         resultArray[i] = new Random().Next(100, 1000);
//     }
//     return resultArray;
// }
// int[] array = GetArray(5, 100, 1000);
// Console.WriteLine($"Массив: [ {String.Join(" ; ", array)}]");

// int evenNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    if (array[i] % 2 == 0)
//     {
//         evenNumber += 1; 
//     }
// }
// Console.WriteLine($"Чётных чисел: {evenNumber}");

// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

// int[] GetArray (int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];
//     for (int i = 0; i < resultArray.Length; i++) 
//     {
//         resultArray[i] = new Random().Next(9, 100);
//     }
//     return resultArray;
// }
// int[] array = GetArray(5, -9, 100);
// Console.WriteLine($"Массив: [ {String.Join(" ; ", array)}]");
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(i % 2 != 0)
//     sum = sum + array[i];
// }
//  Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double[9];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round((new Random().NextDouble() * new Random().Next(10, 100)),2);
// } 

// Console.WriteLine($"Массив вещественных чисел: [ {String.Join("; ", array)}]");

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min) 
//     {
//         min = array[i];
//     }
//     else if (array[i] > max) 
//     {
//         max = array[i];
//     }
    
// }
// Console.WriteLine($"Максимальное значение равно: {max}");
// Console.WriteLine($"Минимальное занчение равно: {min}");
// Console.WriteLine($"Разница между ними равна: {max - min}");