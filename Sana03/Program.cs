using static System.Math;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
 
    int count;
    double[] arr;
    Console.WriteLine("Введіть кількість елементів масиву");
    count = int.Parse(Console.ReadLine());
    arr = new double[count];
    Console.WriteLine("Введіть елементи масиву:");
for (int i = 0; i < count; i++)
    {
        arr[i] = double.Parse(Console.ReadLine());
    }
    double sumOfNegative =0 ;
    double min = int.MaxValue;
    double max = int.MinValue;
    double index = 0;
    double maxModule = 0;
    double sumPositiveIndices = 0;
    int countOfInt = 0;
  

    for (int i = 0; i < count; i++)
    {

        if (arr[i] < 0)
        {
             sumOfNegative += arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (max < arr[i])
        {
            max = arr[i];
            index = i;
        }
        if (Abs(maxModule) < Abs(arr[i]))
        {
            maxModule = arr[i];
        }
        if (arr[i] > 0)
        {
            sumPositiveIndices += i;
        }
        if (arr[i] % 1 == 0)
        {
            ++countOfInt;
        }

    }
    Console.WriteLine($"Сума від'ємних елементів: {sumOfNegative}");
    Console.WriteLine($"Мінімальний елемент: {min}");
    Console.WriteLine($"Індекс максимального елемента: {index}");
    Console.WriteLine($"Максимальний за модулем елемент: {maxModule}");
    Console.WriteLine($"Сума індексів додатних елементів: {sumPositiveIndices}");
    Console.WriteLine($"Кількість цілих чисел: {countOfInt}");
