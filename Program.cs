// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма.

Console.WriteLine("Введите текст. Не меннее 10 слов.");
string text = string(Console.ReadLine());

string [] separators = {" ", ",", ".", "-", ";", ":", "!", "?"};
string [] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntrise);

int i = 0;
int j = 0;
string [] newWords = words;
string s = ' ';

for (i = 0; i < words.Length; i++)
{
    words[i] = words[i] + s;
    if ((words[i].LastIndexOf(s) <= 2))
    {
         newWords[j] = words[i];
         Console.Write($" {newWords[j]}");
         j++;
    }
}

  void PrintArray(string[] inArray) // вывод на печать
{
    
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[j]} ");
        }
        Console.WriteLine();
    
}

PrintArray(newWords);