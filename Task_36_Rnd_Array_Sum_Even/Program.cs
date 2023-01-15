// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        int sum = 0;
        for (int i = 0; i < arr_count.Length; i++) {
            if (i % 2 != 0) sum = sum + arr_count[i];
        }
        return sum;
    }
     
    static void Main() {
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход размер массива и его диапазон,
заполняет массив случайными числами, выводит его на экран
и показывает сумму элементов, стоящих на нечетных позициях (индексах).");
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