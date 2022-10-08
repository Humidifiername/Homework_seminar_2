Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.Write(num + " - третьей цифры нет");
}
else if (num > 99)
{
    Console.WriteLine((num % 100) % 10);
}