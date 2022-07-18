using Lesson_5;

var a = new Rational_number(4, 2);
var b = new Rational_number(5, 2);


Console.WriteLine(a == b);
Console.WriteLine(a != b);

Console.WriteLine(a < b);
Console.WriteLine(a > b);

Console.WriteLine(a + 2);
Console.WriteLine(a + 1.5);
Console.WriteLine(a + b);

Console.WriteLine(a - 2);
Console.WriteLine(a - 1.5);
Console.WriteLine(a - b);

Console.WriteLine((double)a++ );
Console.Write("\n\n");
Console.WriteLine((int)a-- );
Console.Write("\n\n");

Console.WriteLine(a * 2);
Console.WriteLine(a * 1.5);
Console.WriteLine(a * b);

Console.WriteLine(a / 2);
Console.WriteLine(a / 1.5);
Console.WriteLine(a / b);

Console.WriteLine("The end");

