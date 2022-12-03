// Задача 25: Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (А и В) и
// возводит число А в степень В. 3, 5 -> 243(3^5); 2, 4 -> 16.
void Task25_1()
{
    Console.WriteLine("Программа принимает на вход два натуральных числа (А и В) и возводит число А в степень В.");
    Console.Write("Введите первое число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}.");
    Console.WriteLine(" ");
}

void Task25_2()
{
    Console.WriteLine("Программа принимает на вход два натуральных числа (А и В) и возводит число А в степень В.");
    Console.Write("Введите первое число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine($"{A}^{B} = {result}");
    Console.WriteLine(" ");
}

void Task25_3()
{
    Console.WriteLine("Программа принимает на вход два натуральных числа (А и В) и возводит число А в степень В.");
    Console.Write("Введите первое и второе число через пробел: ");
    string numbersAB = Console.ReadLine();
    string[] numbersABSplit = numbersAB.Split();
    Console.WriteLine($"{Convert.ToInt32(numbersABSplit[0])}^{Convert.ToInt32(numbersABSplit[1])} = " 
                    + $"{Math.Pow(Convert.ToInt32(numbersABSplit[0]), Convert.ToInt32(numbersABSplit[1]))}.");
    Console.WriteLine(" ");
}

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. 452 -> 11; 82 -> 10; 9012 -> 12.
void Task27()
{
    Console.WriteLine("Программа задаёт случайное число и выводит сумму цифр в числе.");
    Random rand = new Random();
    int number = rand.Next(10,10000);
    Console.WriteLine("Задано случайное число: " + number);
    int sum = 0;
    Console.Write($"Сумма цифр числа {number} равна ");
    while(number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }    
    Console.WriteLine(sum);
    Console.WriteLine(" ");
}

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив. -2, 1, -7, 5, 19 -> [1,-2,5,-7,19].

void FillArray(int[] nums)
{
    int size = nums.Length;
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-90,90);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + "   ");
    }
    Console.WriteLine();
}

void SortArray(int[] nums)
{
     for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = 0; j < nums.Length - 1 - i; j++)
        {
            if (Math.Abs(nums[j]) > Math.Abs(nums[j+1]))
            {
                int temp = nums[j];
                nums[j] = nums[j+1];
                nums[j+1] = temp;
            }
        }
    }
}

void Task29()
{
    Console.WriteLine("Программа задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);
    PrintArray(numbers);
}

Task25_1();
Task25_2();
Task25_3();
Task27();
Task29();
