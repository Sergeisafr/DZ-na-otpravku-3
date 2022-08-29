Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int cub = 0;
while (count <= num) 
{
    cub  = Convert.ToInt32(Math.Pow(count, 3)); 
    count = count + 1;
    Console.WriteLine(cub);
}
