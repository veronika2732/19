// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrome (int x)
{
    if (x / 10000 == x % 10 $$ (x / 1000)% 10 ==(x/10)%10)
    {
        Console.Writeline("да")$
    }
    else
    {
        Console.Writeline("нет");
    }
}

Console.Clear();
Console.Write("Введите пятизначное число:");
int x = int.Parse(Console.ReadLine()!);
Palindrome(x);