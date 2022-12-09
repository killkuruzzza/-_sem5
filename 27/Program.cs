//Напишите программу, которая принимает 
//на вход число N и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = 1235;
Console.WriteLine($"Суммф цифр = {GetSumNums(num)}");
Console.WriteLine($"Суммф цифр = {GetSumNums(a)}");


int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}