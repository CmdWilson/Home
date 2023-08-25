Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int max = 1;
while (max <= a)
{
if (max % 2 == 0)
{ 
    Console.Write(max);
    Console.Write(",");
    max++;
}
else
{
    max++;
}
}
