// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Введите число: ");

int sum = 0;
while (number > 0) 
{
    sum = sum + number % 10; 
    number = number/10; 
}
System.Console.WriteLine (sum);