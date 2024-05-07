Console.WriteLine("Enter first number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine());
void CheckMultiplyable(int a, int b)
{
    if (a % 2 == 0 && a % 4 == 0 && b % 2 == 0 && b % 4 == 0)
    {
        if (a % 8 == 0 && b % 8 == 0)
        {
            Console.WriteLine("The numbers can be multiplied by 8");
        }
        else
        {
            Console.WriteLine("At least one number can not be multiplied by 8");
        }
    }
    else
    {
        Console.WriteLine("At least one number can not be multiplied by 8");
    }
}
CheckMultiplyable(first, second);


Console.WriteLine("Enter first side");
int firstSide = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second side");
int secondSide = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third side");
int thirdSide = int.Parse(Console.ReadLine());

void MakeTriangle(int a, int b, int c)
{
    if ((a < Math.Abs(b-c)) || (a > b + c) || (b < Math.Abs(a - c)) || (b > a + c) || (c <Math.Abs(a - b)) || (c > a + b))
    {
        Console.WriteLine("Triangle is not possible");
    }
    else if(a==b && b==c)
    {
        Console.WriteLine("The triangle id equilateral");
    }
    else if(a==b || b == c)
    {
        Console.WriteLine("The triangle is isosceles");
    }
    else
    {
        Console.WriteLine("The triangle is scalene");
    }
}

MakeTriangle(firstSide, secondSide, thirdSide);




