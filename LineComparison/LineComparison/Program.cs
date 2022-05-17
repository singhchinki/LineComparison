// See https://aka.ms/new-console-template for more information
LineComparision.Line linecomparision = new LineComparision.Line();
double length1 = linecomparision.getLength(6, 3, 2, 8);
double length2 = linecomparision.getLength(6, 3, 2, 8);
Console.WriteLine("length of given Line is-" + length1);
Console.WriteLine("length of given Line is-" + length2);
Console.WriteLine(length1.Equals(length2));
