Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

{
if(a > max) max = a; 
if(a < max) min = a; 
if(b > max) max = b;
if(b < max) min = b;
}

Console.Write("max = ");
Console.WriteLine (max);

Console.Write("min = ");
Console.WriteLine (min);


