Console.WriteLine("Введите число: ");
bool num1 = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите число: ");
bool num2 = int.TryParse(Console.ReadLine(), out int b);

if (!num1 || !num2  )
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int index = b-a;
PrintResult(GetSum(a,b));
int GetSum(int a, int b,int i = 0)
{

    if(i<index)
    {
        i++;
     return  a+ GetSum(a+1,b,i);
    }
    
   return a;
}

void PrintResult(int i)
{
    Console.WriteLine(i);
}