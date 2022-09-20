Console.WriteLine("Введите начальное число M:");
bool number1 = int.TryParse(Console.ReadLine(), out int numberM);

Console.WriteLine("Введите начальное число N:");
bool number2 = int.TryParse(Console.ReadLine(), out int numberN);

if (!number1 || !number2 || numberM <0 || numberN <0)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}
else if (numberM >= 3 && numberN >10 || numberM >= 4 && numberN >0 || numberM >= 5 && numberN >=0 )
    {
    Console.WriteLine("Значение слишком велико для решения через рекурсию, попробуйте ввести значение меньше.");
    }
else
{
    Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
}

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

