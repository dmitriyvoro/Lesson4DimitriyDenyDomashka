Console.Clear();
Console.WriteLine("Введите 1-е число");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int b =Convert.ToInt32(Console.ReadLine());
int result  =1;
for (int i =1;i<=b;i++)
{
    result = result *a;
}
Console.WriteLine(result);