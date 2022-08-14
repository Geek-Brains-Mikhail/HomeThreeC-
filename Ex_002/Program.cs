// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GettingCoordinates(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()) ;
}

int x1 = GettingCoordinates("Введите координату X первой точки: ");
int y1 = GettingCoordinates("Введите координату Y первой точи: ") ;
int z1 = GettingCoordinates("Введите координату Z первой точки: ");
int x2 = GettingCoordinates("Введите координату X второй точки: ");
int y2 = GettingCoordinates("Введите координату Y второй точки: ");
int z2 = GettingCoordinates("Введите координату Z второй точки: ");
Console.WriteLine($"Расстояние в 3D пространстве между точкой A({x1},{y1},{z1}) и точкой  B({x2},{y2},{z2}) равно {Math.Round(Math.Sqrt( ((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1) * (z2-z1))) ,2)}") ; 