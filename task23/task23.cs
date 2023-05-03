//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число от 1 до N: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] num_array = new int[num];

if (num >= 1)
{
    for (int i = 0; i < num_array.Length; i++)
    {
        num_array[i] = (i+1)*(i+1)*(i+1);
        Console.Write(num_array[i]);
        Console.Write(", ");
    }
    
}
else Console.WriteLine("Вы ввели не верное значениеЙ");