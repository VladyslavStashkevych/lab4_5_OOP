// Program.cs
using lab4_5;
Integer s1 = new Integer();
INumber s2 = new Integer();
Real r1 = new Real();
INumber r2 = new Real();

s1.Value = 3;
((Integer)s2).Value = 4;
r1.Value = 4.0;
((Real)r2).Value = 10.0;

Console.WriteLine($"{s1.Value} + {((Integer)s2).Value} = {((Integer)s1.Add(s2)).Value}");
Console.WriteLine($"{((Integer)s2).Value} - {s1.Value} = {((Integer)s2.Substaction(s1)).Value}");
Console.WriteLine($"{r1.Value} * {((Real)r2).Value} = {((Real)r1.Multiplication(r2)).Value}");
Console.WriteLine($"{((Real)r2).Value} / {r1.Value} = {((Real)r2.Division(r1)).Value:0.00}");
