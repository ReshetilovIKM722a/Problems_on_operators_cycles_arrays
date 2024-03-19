/*
Напишіть програму, яка перевіряє, чи належить введене користувачем
число заданому інтервалу. Використовуйте логічні оператори для перевірки
умови належності числа до інтервалу.
*/

{
    int low = 10;
    int high = 50;

    Console.WriteLine($"Введiть число в iнтервалi вiд {low} до {high}:");
    float numberf = float.Parse(Console.ReadLine());

    if (numberf >= low && numberf <= high)
    {
        Console.WriteLine($"Число {numberf} належить iнтервалу");
    }
    else
    {
        Console.WriteLine($"Число {numberf} не належить iнтервалу!");
    }
}



/*
Напишіть програму для конвертації температури з градусів Цельсія в
градуси Фаренгейта або навпаки. Використовуйте арифметичні операції для
конвертації.
*/

{
    Console.WriteLine("Введiть температуру в Цельсiя:");
    float numbercel = float.Parse(Console.ReadLine());

    double numberfar = (numbercel * 1.8 + 32);
    Console.WriteLine($"Температура в градусах Фаренгейта: {numberfar}");
}



/*
Напишіть програму, яка перевіряє, чи міститься певний елемент у
масиві.
*/
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine($"Масив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();

    Console.WriteLine($"Введiть число для перевiрки:");
    int numb = int.Parse(Console.ReadLine());
    int check = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numb)
        {
            check += 1;
            Console.WriteLine($"Число {numb} є у масивi");
        }
    }
    if (check != 1)
    {
        Console.WriteLine($"Числа {numb} нема у масивi");
    }
}        