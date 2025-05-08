// string GetLettersFromString (string s)
// {
//     string letters = "";
//     foreach(char e in s)
//     {
//         if (char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }

// string str = Console.ReadLine();
// string result = GetLettersFromString(str);
// Console.WriteLine(result);

// Домашнее задание 
// Считать с коноли строку, состоящую из цифр и латинских букв. Сформировать массив, Состоящий из цифр этой строки.

// abc123def06g => [1, 2, 3, 0, 6]

// Рекомендации:
// - Разделить логику алгоритма на функции
// - Память под массив выделять необходимого размера (не больше, чем количество элементов)

char[] GetDigitsFromStr(string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if(char.IsDigit(e) == true)
        {
            digits = digits + e;
        }
    }
    char[] chars = digits.ToCharArray();
    return chars;
}

void PrintArray(char[] chars)
{
    foreach (char e in chars)
    {
        System.Console.Write($"{e} ");
    }
}

string str = System.Console.ReadLine();
char[] result = GetDigitsFromStr(str);
PrintArray(result);