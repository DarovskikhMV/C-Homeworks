// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 

// Указание
// Конструктор строки вида string(char []) не использовать.

// char[] array = {'a', 'b', 'c', 'd'};

// string ArrayString(char[] text)
// {
//     string result = string.Empty;
//     for(int i = 0; i < array.Length; i++)
//     {
//         result = result + array[i];
//     }
//     return result;
// }

// Console.WriteLine(ArrayString(array));

// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

// Указание
// Метод строки ToCharArray() не использовать.



// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// using System.Text.Encodings.Web;

// string text = "Hello!";

// char[] ArrayFromString(string array)
// {   
//     char[] test = new char[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         test[i] = array[i];
//     }
//     return test;
// }
// // Console.WriteLine(typeof(ArrayFromString(text)));
//  Console.WriteLine(ArrayFromString(text).GetType());

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// // Выяснить, сколько среди введённых букв гласных
// using System.Xml.XPath;

// Console.WriteLine("Введите текст");
// string text = Console.ReadLine();

// int VowelsMethod(string line)       //кол-во гласных в тексте
// {   
//     int result = 0;
//     char[] vowels = {'a', 'o', 'e', 'u', 'i','y'};
//     for(int i = 0; i < line.Length; i++)
//     {
//         for(int j = 0; j < vowels.Length; j++)
//         {
//             if(vowels[j]==line[i])
//             {
//                 result++;
//             }
//         }
//     }
//     return result;
// }

// Console.WriteLine(VowelsMethod(text));


//Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// char[,] array = {{'a', 'b', 'c'}, 
//                  {'d', 'e', 'f'}};

// string ArrayString(char[,] array)    // перевод из двумерного массива в строку
// {
// string result = string.Empty;   
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         result = result + array[i, j];
//     }    
// }
// return result;
// }
// Console.WriteLine(ArrayString(array));

// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// Console.WriteLine("Введите строку");
// string text = Console.ReadLine().ToLower();
// Console.WriteLine(text);

// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// Console.WriteLine("Введите строку");
// string text = Console.ReadLine().ToLower();

// string Palindrom(string line)     //проверка на палиндром 
// {
//     string result = string.Empty;
//     for(int i = 0; i < line.Length; i++)
//     {
//         result = line[i] + result;
//     }
//     if(result == line)
//         Console.WriteLine("Это палиндром");
//         else
//         Console.WriteLine("Это не палиндром");

//     return result;    
// }

// Palindrom(text);


// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// Console.WriteLine("Введите строку");
// string? text = Console.ReadLine();

// string ReverseString(string line)   // перевернуть строку в обратном порядке
// {
//     string[] stringArray = text.Split(" ");
//     string result = string.Empty;

//     for(int i = 0; i < stringArray.Length; i++)
//     {
//         result = stringArray[i] + " " + result;
//     }

// //   for(int i = stringArray.Length-1; i >=0; i--)
// //   {
// //     result = result + stringArray[i] + " ";
// //   }
//   return result;
// }

// Console.WriteLine(ReverseString(text));


// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.


using System.Xml.XPath;

Console.WriteLine("Введите ваше число:");
int number = Convert.ToInt32(Console.ReadLine());

int SummNumber(int num)   //возврат суммы чисел от числа
    {
        if (num < 10) 
        {
            return num;
        }
        else 
        {
            return num % 10 + SummNumber(num / 10);
        }
    }

Console.WriteLine("Сумма цифр числа:" + SummNumber(number));

