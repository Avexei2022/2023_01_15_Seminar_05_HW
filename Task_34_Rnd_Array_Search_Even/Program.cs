// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

class LearningArray {
    static int[] GetIntRndArray(int size, int first, int last) {
        int[] IntRndArr = new int[size];
        for (int i = 0; i < size; i++) {
            IntRndArr[i] = new Random().Next(first, last + 1);
        }
        return IntRndArr;
    }

    static void PrintArray(int[] array) {
        Console.Write($"[ {String.Join(", ", array)} ] -> ");
    }

    static int GetResult(int[] arr_count) {
        int count = 0;
        for (int i = 0; i < arr_count.Length; i++) {
            if (arr_count[i] % 2 == 0) count++;
        }
        return count;
    }
     
    static void Main() {
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход размер массива
заполняет массив случайными трехзначными числами, выводит его на экран
и показывает количество четных чисел в массиве.");
        Console.WriteLine();
        Console.Write("Введите количество элементов в массиве: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int min = 100;
        int max = 999;
        int[] myIntRndArr = GetIntRndArray(num, min, max);
        PrintArray(myIntRndArr);
        Console.WriteLine(GetResult(myIntRndArr));
        Console.WriteLine();
    }
}