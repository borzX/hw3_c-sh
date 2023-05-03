// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_string = Convert.ToString(num);
int num_length = Convert.ToString(num).Length;
char[] num_array = new char[num_length];

if (num_length == 5)
{
    for(int i = 0; i < num_length; i++)
    {
        num_array[i]=num_string[i];  
    }

    if (num_array[0]==num_array[4] && num_array[1]==num_array[3]) 
    {
        Console.WriteLine($"Число {num} является палиндромом");
        
    }
    else Console.WriteLine($"Число {num} НЕ является палиндромом");
}
else Console.WriteLine("Вы ввели не пятизначное число!");