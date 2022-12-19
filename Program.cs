// Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.

// int SummNumbers(int num)
// {
//     int summ = 0;
//     for(int i = 1; i<=num; i++)
//         summ += i;
//     return summ;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");




// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

// int Chislo(int N)
// {
//     if (N == 0)
//     {
//         return 1;
    
//     }
//     else 
//     {
//         int i = 0;
//     while (N > 0)
//     {
//         i++;
//         N = N / 10;
//     }
//     return i;
//     }
    
// }

// Console.Write("Enter your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = Chislo(N);
// Console.WriteLine($"количество цифр равно {res}");




// Напишите программу, которая принимает на вход число (N) и выдает произведение от 1 до N.

// int Fact(int N)
// {
//     if (N < 0)
//     {
//         N = N * (-1);
//     }
//     int f = 1;
//     for (int i = 2; i <= N; i++)
//     {
//         f *= i;
//     }
//     return f;
// }

// Console.Write("Enter your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = Fact(N);
// Console.WriteLine($"Факториал числа {N} равен {res}");



// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// int[] Array()
// {
//     int [] arr = new int [8];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr;
// }
// void ShowArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }


// ShowArray(Array());

// Напишите программу, которая выводит массив из количества элементов, заданные пользователем, заполненный числами от 5 до 15 в случайном порядке

int[] Array(int N)
{
    int [] arr = new int [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(5,16);
    }
    return arr;
}
void ShowArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Write your length: ");
int lengthMass = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(lengthMass));