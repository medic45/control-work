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