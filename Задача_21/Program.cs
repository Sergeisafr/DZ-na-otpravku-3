Console.Write("Введите координату Х первой точки: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите координату Х второй точки: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double size = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2) );
Console.Write(size);
