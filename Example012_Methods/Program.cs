// Вид 1 - ничего не принимают, ничего не возвращают
void Method()
{
    Console.WriteLine("Автор: Никита Харчук");
}
// Method(); // таким образом вызывается метод






// Вид 2 - что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкримент
    }
}
// Method21(msg:"Текст", count: 4); //именновые аргументы, их необязательно писать по порядку





// Вид 3 - ничего не принимают, что-то возвращают (нужны, например, для генерации случайных данных);
int Method3()  //если метод что-то возвращает, то обязательно надо указывать тип данных
{
    return DateTime.Now.Year; //команда return обязательна для методов, которые возвращают
}
int year = Method3();
// Console.WriteLine(year);





// Вид 4 - что-то принимают, что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //пустая строка

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }


string Method4(int count, string text)
{
    string result = String.Empty; //пустая строка

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "asdf");
// Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }




// ======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//    012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'C', 'c');
// Console.WriteLine(newText);





int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

