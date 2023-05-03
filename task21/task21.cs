// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


//Вводим координаты точки А(x,y,z)
int[] a_array = new int[3];
Console.Write("Введите координаты X точки А: ");
a_array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки А: ");
a_array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки А: ");
a_array[2] = Convert.ToInt32(Console.ReadLine());

//Вводим координаты точки B(x,y,z)
int[] b_array = new int[3];
Console.Write("Введите координаты X точки B: ");
b_array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
b_array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки B: ");
b_array[2] = Convert.ToInt32(Console.ReadLine());

//Проверяев ввод
Console.WriteLine($"Координаты точки А: ({a_array[0]}, {a_array[1]}, {a_array[2]})");
Console.WriteLine($"Координаты точки B: ({b_array[0]}, {b_array[1]}, {b_array[2]})");

//Находим квадрат разницы
double x_pow = Math.Pow(b_array[0]-a_array[0],2);
double y_pow = Math.Pow(b_array[1]-a_array[1],2);
double z_pow = Math.Pow(b_array[2]-a_array[2],2);

//Находим сумму квадратов
double xyz_pow_sum = x_pow+y_pow+z_pow;

//Находим квадратный корень от сумы квадратов
double result = Math.Round(Math.Sqrt(xyz_pow_sum),2);

//Ответ
Console.WriteLine($"Расстояние между точками А и В равно: {result}");