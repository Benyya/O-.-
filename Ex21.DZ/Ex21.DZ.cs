//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.//
//x = n ,y = e , z = w -  Хотел немного прикольно сделать - задумка не получилась)
int n1 = Coordinate("n", "A");
int e1 = Coordinate("e", "A");
int w1 = Coordinate("w", "A");
int n2 = Coordinate("n", "B");
int e2 = Coordinate("e", "B");
int w2 = Coordinate("w", "B");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double n1, double n2, 
                double e1, double e2, 
                double w1, double w2){
  return Math.Sqrt(Math.Pow((n2-n1), 2) + 
                   Math.Pow((e2-e1), 2) + 
                   Math.Pow((w2-w1), 2));
}

double segmentLength =  Math.Round (Decision(n1, e2, w1, n2, e1, w2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
