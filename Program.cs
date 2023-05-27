Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max>b)
{
    System.Console.WriteLine("max=" + a);
    System.Console.WriteLine("min=" + b);
}
else 
{
    System.Console.WriteLine("max=" + b);
    System.Console.WriteLine("min=" + a);
}
