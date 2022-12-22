// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма.

// Console.WriteLine("Введите текст. Не меннее 10 слов.");
// string text = Console.ReadLine();
string text = "привет, дом мама ура! солнце 123 забор 2?5 66 нгш ";

string [] separators = {" ", ",", ".", "-", ";", ":", "!", "?"};
string [] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int i = 0;
int j = 0;
string [] newWords = words;
char s = ' ';

int n = words[0].LastIndexOf(s);

for (i = 0; i < words.Length; i++)
{
    words[i] = words[i] + s;
   
    if (((words[i].LastIndexOf(s)-1) <= 2))
         newWords[j] = words[i];
    else
        newWords[j] = new string(" ");

         j++;
}

  void PrintArray(string[] inArray) // вывод на печать
{
    
        for (int j = 0; j < inArray.Length; j++)
        {
            Console.Write($" {inArray[j]}");
            Console.WriteLine();
        }
}

PrintArray(newWords);