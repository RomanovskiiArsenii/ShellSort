class Program
{
    public static void ShellSort(int[] array)
    {
        int n = array.Length;
        int gap = n / 2;        // Инициализируется начальное значение интервала (gap),
                                // равное половине длины массива (n / 2). 

        while (gap > 0)         //Пока значение интервала больше нуля, выполняется цикл
        {
            for (int i = gap; i < n; i++)                       //Внутренний цикл перебирает элементы массива, начиная с позиции gap.
            {
                int temp = array[i];                            //На каждой итерации внутреннего цикла выбирается текущий элемент (temp) и его индекс (i).
                int j = i;
                while (j >= gap && array[j - gap] > temp)       // сравнение первой и второй части массива
                {
                    array[j] = array[j - gap];                  // обмен значений ч.1
                    j -= gap;                                   // выход из цикла 
                }

                array[j] = temp;                                // обмен значений ч.1
            }

            gap /= 2;                                           // уменьшаем интервал в 2 раза
        }
    }
    static void Main()
    {
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine();
            Random random = new Random();
            int[] array = Enumerable.Range(1, 9).Select(x => random.Next(10)).ToArray();
            foreach (int i in array) { Console.Write($"{i} "); }
            Console.WriteLine();
            ShellSort(array);
            foreach (int i in array) { Console.Write($"{i} "); }
        }
    }
}
