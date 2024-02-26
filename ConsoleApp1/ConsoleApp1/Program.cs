Console.WriteLine("Sayı girin:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; number > i; i++)
{
    if (number % i == 0)
    {
        Console.WriteLine("Asal değil");
        break;
    }
    else if (i == number - 1)
    {
        Console.WriteLine("Asal");
    }
}