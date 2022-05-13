// See https://aka.ms/new-console-template for more information
using UtilityLibrary;

Console.WriteLine($"Add: 12 + 3 = {MathLib.Add(12, 3)}");
Console.WriteLine($"Sub: 12 - 3 = {MathLib.Subtract(12, 3)}");
Console.WriteLine($"Mul: 12 * 3 = {MathLib.Multiply(12, 3)}");
Console.WriteLine($"Div: 12 / 3 = {MathLib.Divide(12, 3)}");
Console.WriteLine($"Mod: 12 % 3 = {MathLib.Modulo(12, 3)}");
Console.WriteLine($"Fn1: 12     = {MathLib.Fn1(12)}");


Console.WriteLine($"Concat      = {StringLib.Concat("ABC", "xyz")}");
Console.WriteLine($"UpperCase   = {StringLib.UpperCase("ABCxyz")}");
Console.WriteLine($"LowerCase   = {StringLib.LowerCase("ABCxyz")}");
Console.WriteLine($"TitleCase   = {StringLib.TitleCase("ABCxyz")}");