// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        int result = 0;
        int min = arr_count[0];
        int max = arr_count[0];
        for (int i = 1; i < arr_count.Length; i++) {
            if (arr_count[i] < min) min = arr_count[i];
            if (arr_count[i] > max) max = arr_count[i];
        }
        result = max - min;
        return result;
    }
     
    static void Main() {
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход размер массива
заполняет массив случайными числами, выводит его на экран
и показывает разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine();
        Console.Write("Введите количество элементов в массиве: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите первое число случайно генерируемого диапазона: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите последнее число случайно генерируемого диапазона: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] myIntRndArr = GetIntRndArray(num, min, max);
        PrintArray(myIntRndArr);
        Console.WriteLine(GetResult(myIntRndArr));
        Console.WriteLine();
    }
}
