public class Itog
{
    static void Zadanie()
    {
        Console.WriteLine("Итоговая контрольная работа!");  
        // Исходя из исловия задачи необходимо создать два массива:
        // массив с исходными данными и рассив с результатами
        
        // для начала дадим возможность пользователю ввести размер исходного массива и значений массива
        Console.Write("Введите количество элементов: ");
        int size =  Convert.ToInt32(Console.ReadLine());
        // создаем массивы размером size
        string[] Input = new string[size];
        string[] Result = new string[size];
        // объявим счетчик дла подсчета подходящих строк
        int count = 0;
        // заполним массив различными строками с помощью цикла
        string ResStr = "";
        for (int i = 0; i < size; i++)
        {
            Console.Write($"    Введите строчку массива №{i+1}: ");
            Input[i] = Console.ReadLine();
            if (i < size-1) ResStr = ResStr +"['" + Input[i]+ "'], " ;
            // будем проверять что в веденной строке 3 или более символов
            if (Input[i].Length <= 3)
            {
                Result[count] = Input[i];
                count++;
            }
        }
        
        ResStr = ResStr +"['"+Input[size-1]+"'] -> ['";

        for (int i = 0; i<count-1; i++)
        {
            ResStr = ResStr + Result[i] + "'], ['";
        }

        ResStr = ResStr + Result[count-1] + "'].";
        // Выводим результат!
        Console.WriteLine("Результат работы программы: ");  
        Console.Write(ResStr);

    }

    static void Main()
    {
        Console.Clear();
        Zadanie();
    }
}

