class Program
{
    static void Main()
    {
        // Введите строки через запятую и пробел
        Console.WriteLine("Введите строки через запятую и пробел:");
        string input = Console.ReadLine();

        // Разбиваем введенную строку на подстроки по запятой и пробелу
        string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.None);

        // Создаем новый массив для хранения строк длиной не более 3 символов
        string[] resultArray = FilterShortStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }
    static string[] FilterShortStrings(string[] inputArray)
    {
        // Считаем количество строк, которые удовлетворяют условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с учетом количества строк, удовлетворяющих условию
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}