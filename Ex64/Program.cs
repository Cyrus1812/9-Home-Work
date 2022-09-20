Console.WriteLine("Введите число начала отсчета: ");
bool line = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число конца отсчёта: ");
bool column = int.TryParse(Console.ReadLine(), out int n);

if (!line || m < 1 || !column || n < 1)
{
Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}
int index = n-m;
int[] newArray = new int[index+1];
newArray = Recursive(n,0,m,newArray);
PrintArray(newArray);
int[] Recursive(int n , int i,int m ,int[]array )
{
if (i>index)
{
return array;
}
array[i] = m;
Recursive(n,i+1,m+1, array);
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($" {array[i]} ");
}
}
