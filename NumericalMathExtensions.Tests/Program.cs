using NumericalMathExtensions;

int x = 5;
int y = 8;

Console.WriteLine(39.ToRadians());
Console.WriteLine(50.Cast<int, double>().IsZero());
Console.WriteLine(0.ToRadians().IsZero());
Console.WriteLine(39.ToRadians<int, float>());
Console.WriteLine(x.IsGreaterThan(y));
Console.WriteLine(x.Min(y));