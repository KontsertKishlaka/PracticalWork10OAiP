namespace PracticalWork10OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Задание 1: Вывод чётных чисел массива.\n");
        Console.ForegroundColor = ConsoleColor.White;

        int[] userArray = ReadArray();
        int[] evenArray = GetEvenArray(userArray);
        PrintArray(evenArray);
        evenArray = null;



        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\nЗадание 2: Вывод количества отрицательных чисел массива.\n");
        Console.ForegroundColor = ConsoleColor.White;

        userArray = ReadArray();
        Console.WriteLine($"Количество негативных чисел в массиве: {GetNegativeNumbersCount(userArray)}");



        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\nЗадание 3: Проверка на наличие в массиве заданного пользователем числа.\n");
        Console.ForegroundColor = ConsoleColor.White;

        userArray = ReadArray();
        int userNumber = GetUserNumber();
        CheckUserNumberInArray(userNumber, userArray);
    }

    private static void CheckUserNumberInArray(int userNumber, int[] userArray)
    {
        foreach (var number in userArray)
        {
            if (number == userNumber)
            {
                Console.WriteLine($"\nЗаданное вами число \"{userNumber}\" ЕСТЬ в массиве.");
                return;
            }
        }

        Console.WriteLine($"\nЗаданного вами числа \"{userNumber}\" НЕТ в массиве.");
    }

    private static int GetUserNumber()
    {
        Console.WriteLine("\nВведите число, наличие которого будем проверять: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int[] ReadArray()
    {
        Console.WriteLine("Введите размер массива: ");
        var size = Convert.ToUInt16(Console.ReadLine());

        int[] userArray = new int[size];

        Console.WriteLine("\nВведите массив: ");
        for (int i = 0; i < size; i++)
        {
            userArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        return userArray;
    }

    private static int[] GetEvenArray(int[] targetArray)
    {
        List<int> evenList = [];

        for (int i = 0; i < targetArray.Length; i++)
            if (targetArray[i] % 2 == 0)
                evenList.Add(targetArray[i]);

        int[] evenArray = [.. evenList];

        return evenArray;
    }

    private static int GetNegativeNumbersCount(int[] targetArray)
    {
        int negativeCounter = 0;

        for (int i = 0; i < targetArray.Length; i++)
            if (targetArray[i] < 0)
                negativeCounter++;

        return negativeCounter;
    }

    private static void PrintArray(int[] evenArray)
    {
        short index = 1;

        Console.WriteLine();

        foreach (var number in evenArray)
        {
            Console.WriteLine($"{index}-й чётный элемент массива: {number}");
            index++;
        }
    }
}