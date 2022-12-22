// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма.


// У Лукоморья дуб зеленый, златая цепь на дубе том. 
// И днем, и ночью кот ученый все ходит по цепи кругом.

Console.Clear();

Console.WriteLine("Введите текст. Не меннее 10 слов.");
string text = Console.ReadLine();

string [] separators = {" ", ",", ".", "-", ";", ":", "!", "?"};
string [] Words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int i = 0;
int j = 0;
string [] tempWords = new string[Words.Length];// пустой доп массив
char s = ' ';

// метод возвращает доп массив из 3х символьных строк и пустых строк вместо строк длинее 3 символов
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

string text1 = tempWords[0];

// метод возвращает строку из элементов доп массива
String Text1(string [] inArray) 
{
    for (j = 1; j < inArray.Length; j++)
    text1 = text1+inArray[j];
    return(text1);
}
 
 // метод выводит результат (массив) на печать
  void PrintArray(string[] inArray) 
{
    for (int j = 0; j < inArray.Length; j++)
        {
            Console.Write($" {inArray[j]}");
            Console.WriteLine();
        } 
}

TempArray(Words);
Text1(tempWords);

//создаем массив, в котором длина всех эелементов <= 3 символам 
string [] newWords = text1.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintArray(newWords);

