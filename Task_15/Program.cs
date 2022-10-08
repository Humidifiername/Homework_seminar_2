// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine(num + " нет");
}
else if (num == 2)
{
    Console.WriteLine(num + " нет");
}
else if (num == 3)
{
    Console.WriteLine(num + " нет");
}
else if (num == 4)
{
    Console.WriteLine(num + " нет");
}
else if (num == 5)
{
    Console.WriteLine(num + " нет");
}
else if (num == 6)
{
    Console.WriteLine(num + " да");
}
else if (num == 7)
{
    Console.WriteLine(num + " да");
}
else
{
    Console.Write("Вы ввели некорректное число");
}