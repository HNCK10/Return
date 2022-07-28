// See https://aka.ms/new-console-template for more information
//return - returns data back to where the method is invoked
double x, y,j,z, result,result2;
Console.WriteLine("Enter number 1: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number 3: ");
j = Convert.ToDouble(Console.ReadLine());
static double Multiply(double x, double y)
{
    double z = x * y;
    return z;
}
//method overloading = methods share same name, but different parameters
//name+parameters=signature
//methods must have a unique signature
static double Multiply2(double x, double y, double j)
{
    return x*y*j;
}
result = Multiply(x, y);
result2 = Multiply2(x, y, j);
Console.WriteLine("Number 1 times number 2 is "+ result+ " Number 1 times number 2 times number 3 is "+result2);
Console.ReadKey();