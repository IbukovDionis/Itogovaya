public class Itog
{
    static void Zadanie()
    {
        Console.WriteLine("Итоговая контрольная работа!");  
        // Исходя из исловия задачи необходимо создать два массива:
        // массив с исходными данными и рассив с результатами
        
        // для начала дадим возможность пользователю ввести размер исходного массива и значений массива
        Console.WriteLine("Введите количество элементов:");
        int size =  Convert.ToInt32(Console.ReadLine());
        // создаем массивы размером size
        string[] Input = new string[size];
        string[] Result = new string[size];
        // объявим счетчик дла подсчета подходящих строк
        int count = 0;
        // заполним массив различными строками с помощью цикла
        for (int i = 0; i < size; i++)
        {
            Input[i] = Console.ReadLine();
            // будем проверять что в веденной строке 3 или более символов
            if (Input[i].Length >= 3)
            {
                Result[count] = Input[i];
                count++;
            }
        }
        // Теперь выводим результат - массив со строками в которых не меньше 3 символов
        for (int i = 0; i<=count; i++)
        {
            Console.Write($"[{Result[i]}],");
        }


    }

    static void Main()
    {
        Console.Clear();
        Zadanie();
    }
}

