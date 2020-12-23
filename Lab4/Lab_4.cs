using System;

namespace Lab4
{
class Program
{
static void Main(string[] args)
{
B classB = new B(3, 4);
C<string> classC_string = new C<string>();
C<int> classC_int = new C<int>();
Console.WriteLine("Первый массив:");
foreach(var ind in classB.arrayClass1)
{
Console.WriteLine(ind);
}
Console.WriteLine("Второй массив:");
foreach (var ind in classB.arrayClass2)
{
Console.WriteLine(ind);
}
}
}
}
