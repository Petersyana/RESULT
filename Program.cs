// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма.


// У Лукоморья дуб зеленый, златая цепь на дубе том. 
// И днем, и ночью кот ученый все ходит по цепи кругом.

Console.Clear();

Console.WriteLine("Введите текст");
string text = Console.ReadLine();

string [] separators = {" ", ",", ".", "-", ";", ":", "!", "?"};
int i = 0;
char s = ' ';

string [] Words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string [] tempWords = new string[Words.Length];// пустой доп массив
string text1 = tempWords[0];

// метод возвращает доп массив из 3х символьных элементов массива и пустых ячеек вместо строк длинее 3 символов
string [] TempArray (string [] inArray) 
{
for (i = 0; i < inArray.Length; i++)
{
    inArray[i] = inArray[i] + s;
    if (((inArray[i].LastIndexOf(s)-1) <= 2))
         tempWords[i] = inArray[i];
}
return(tempWords);
}

// метод возвращает строку из всех символьных элементов доп массива
String Text1(string [] inArray) 
{
    for (i = 0; i < inArray.Length; i++)
    text1 = text1+inArray[i];
    return(text1);
}
 
 // метод выводит результат (массив) на печать
  void PrintArray(string[] inArray) 
{
    Console.WriteLine();
    Console.WriteLine("Результат - массив из строк, длина которых не более 3 символов");
    for (int i = 0; i < inArray.Length; i++)
        {
            Console.Write($"     {inArray[i]}");
        } 
}

TempArray(Words);
Text1(tempWords);

//создаем массив, в котором длина всех эелементов <= 3 символам 
string [] newWords = text1.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintArray(newWords);

