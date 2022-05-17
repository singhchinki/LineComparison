// See https://aka.ms/new-console-template for more information
LineComparision.Line linecomparision = new LineComparision.Line();
double length1 = linecomparision.getLength(6, 3, 2, 8);
double length2 = linecomparision.getLength(2, 3, 2, 8);
Console.WriteLine("length of given Line is-" + length1);
Console.WriteLine("length of given Line is-" + length2);
Console.WriteLine(length1.Equals(length2));

private double getLength(double length1, double length2)
{
    if (length1.Equals(length2))
        Console.WriteLine("Length of line" + length1, "is equal" + length2);
    else if (length1 > length2)
        Console.WriteLine("Length of line" + length1, "is greater to" + length2);
    else
        Console.WriteLine("Length of line" + length1, "is less than to" + length2);


}