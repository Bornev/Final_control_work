
class Program
{
    static void Main(string[] args)
    {
        // Ввод исходного массива строк
        Console.WriteLine("Введите строки через пробел:");
        string[] array = Console.ReadLine()!.Split(' ');

        int size = array.Length;
        int index = 0;
        int count = 0;

        // Подсчет количества строк с длиной <= 3
        for (index = 0; index < size; index++)
        {
            if (array[index].Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива для строк с длиной <= 3
        string[] arrayNew = new string[count];
        int IndexArrayNew = 0;

        // Заполнение нового массива строками с длиной <= 3
        for (index = 0; index < size; index++)
        {
            if (array[index].Length <= 3)
            {
                arrayNew[IndexArrayNew] = array[index];
                IndexArrayNew++;
            }
        }

        // Вывод результата
        Console.Write("Строки с длиной <= 3: [");
        for (int i = 0; i < arrayNew.Length; i++)
        {
            Console.Write($"\"{arrayNew[i]}\"");
            if (i < arrayNew.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

    }
}

