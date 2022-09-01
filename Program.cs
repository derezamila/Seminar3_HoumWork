/*
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Numbers(int number){
    int dec = number / 10000;
    int ed = number % 10;
    int result = (number - dec*10000 - ed);
    int dec1 = result / 100;
    int ed1 = number % 10;  
    if(dec == ed || dec1 == ed1){
    Console.WriteLine($"Число {number} является палиндромом");
    }
    else Console.WriteLine($"Число {number} не является палиндромом");
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 10000 && num <= 99999){
    Numbers(num);
}
else Console.WriteLine($"Число {num} не соответствует необходимым параметрам");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

void Distance(){
    double s = 1;
    s = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между двумя точками в пространстве равно {s}");
}

Distance();
/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Num(int n){
    int cub = 1;
    int a = 1;
    while (a <= n){
        cub = a*a*a;
        a ++;
        Console.Write($"{cub} ");
    } 
    Console.WriteLine(" "); 
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Num(num);
*/