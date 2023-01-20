// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

//bool = типо да или нет?
bool Treangle(int x, int y, int z)
{
    if ( (x + y > z) && (x + z > y) && (z + y > x))
    {
        return true;
    }

    return false;
}

Console.WriteLine($"ДАННЫЙ ТРЕУГОЛЬНИК СУЩЕСТВУЕТ ?  ОТВЕТ: {Treangle(a, b, c)}");

