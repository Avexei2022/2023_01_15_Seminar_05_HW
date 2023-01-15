// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

class LearningArray {
    static double[] GetDoubleRndArray(int size) {
        double[] DoubleRndArr = new double[size];
        for (int i = 0; i < size; i++) {
            DoubleRndArr[i] = new Random().NextDouble();
        }
        return DoubleRndArr;
    }

    static void PrintArray(double[] array) {
        Console.Write($"[ {String.Join(", ", array)} ] -> ");
    }

    static double GetResult(double[] arr_count) {
        double result = 0;
        double min = arr_count[0];
        double max = arr_count[0];
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
заполняет массив случайными вещественными числами, выводит его на экран
и показывает разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine();
        Console.Write("Введите количество элементов в массиве: ");
        int num = Convert.ToInt32(Console.ReadLine());
        double[] myDoubleRndArr = GetDoubleRndArray(num);
        PrintArray(myDoubleRndArr);
        Console.WriteLine(GetResult(myDoubleRndArr));
        Console.WriteLine();
    }
}

