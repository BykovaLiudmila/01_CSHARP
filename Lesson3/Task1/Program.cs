//Задача1
double CalculateFormula (int a, int b, int c, int d) //double потому что не хотим потерять дробную часть, если она будет
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);

//Задача 2.
//Вывод на экран квадратов чисел от 1 до N.

