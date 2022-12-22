// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
int DataInput(string str)
{
Console.WriteLine(str);
int number = int.Parse(Console.ReadLine());
return number;
}
int SumNumbers(int num) 
{ 
    int result = 0; 
    while(num > 0) 
    { 
        result += num % 10; 
        num = num / 10;         
    } 
    return result; 
} 
 
Console.Clear(); 
 
int number = DataInput("Введите число "); 
int res = SumNumbers(number); 
 
Console.WriteLine($"{number} -> {res}");
