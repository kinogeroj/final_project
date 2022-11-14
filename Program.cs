Console.Clear();

Console.Write("Вы хотите заполнить массив автоматически? (Yes, если да и No, если нет): "); // Подходит Yes или Y, No или N.
string str = Console.ReadLine();

if ((str == "No") ^ (str == "N")^ (str == "n")) // Массив будет введен вручную.
    
    {

    Console.WriteLine();
    Console.Write("Сколько элементов Вы хотите ввести: ");
    
    int elements = int.Parse(Console.ReadLine());

    string [] OrigArray = FillArrayManual(elements);

    Console.WriteLine($"Получился вот такой массив: [{String.Join(", ", OrigArray)}].");

    string [] ModArray = ModifyArray(OrigArray);

    Console.WriteLine($"После исключения длинных элементов массива (с длиной более 3-х), получился такой массив: [{String.Join(", ", ModArray)}].");

    }

if ((str == "Yes") ^ (str == "Y")^ (str == "y")) // Массив будет сгенерирован автоматически.
    
    {
      
    Console.WriteLine();

    int elements = new Random().Next(1,10);

    string [] OrigArray = FillArrayAuto(elements);

    Console.WriteLine($"Получился вот такой массив: [{String.Join(", ", OrigArray)}].");

    string [] ModArray = ModifyArray(OrigArray);

    Console.WriteLine($"После исключения длинных элементов массива (с длиной более 3-х), получился такой массив: [{String.Join(", ", ModArray)}].");

    }
    
else // Исключение, если пользователь ввел что-то отличное от Yes или No.
    
    {

    Console.WriteLine();
    Console.WriteLine("Вы ввели что-то не то... Запустите программу еще раз, пожалуйста.");

    return;

    }

string [] FillArrayAuto(int length) // Автоматическое заполнение массива.
    
    {

    string [] newarray = new string[length];

        for(int count = 0; count < length; count++) 
        
        {

        int rnd = new Random().Next(1,10);

        newarray[count] = RandomString(rnd);

        }

    return newarray;
    
    }


string RandomString(int length) // Генерирование случайной строки.

    {

    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    
    Random random = new Random();

    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

    }

string [] FillArrayManual(int length) // Заполнение массива вручную.
    
    {

    string [] newarray = new string[length];

        for(int count = 0; count < length; count ++) 
        
        {

        Console.Write($"Введите {count + 1} элемент: ");
        string element = Console.ReadLine();

        newarray[count] = element;

        }

    return newarray;
    
    }

string [] ModifyArray(string [] Array) // Обработка массива. На входе оригинальный массив, на выходе с элементами не длиннее 3-х симовлов.
    
    {
    
    int length = 0;
    int newelements = 0; 

    for(int count = 0; count < Array.Length; count ++) 

        {

        if (Array[count].Length <= 3) 
            
            {

            length ++;

            }

        }

    string [] newarray = new string[length];
    
for(int count = 0; count < Array.Length; count ++) 

        {

        if (Array[count].Length <= 3)
        
            {

            newarray[newelements] = Array[count];

            newelements ++;

            }


        }
    
    return newarray;

    }