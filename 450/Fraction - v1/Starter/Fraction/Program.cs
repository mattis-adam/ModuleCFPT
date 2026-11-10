using FractionsPourTestUnitaires;

Fraction fi1 = new Fraction();
Fraction fi2 = new Fraction(5);
Fraction fi3 = new Fraction(2, 5);
Fraction fi5 = new Fraction(10, 12);
Fraction fi6 = new Fraction(0.5);

Console.WriteLine("fi1 = {0}/{1}", fi1.Numerator, fi1.Denominator);
Console.WriteLine("fi2 = {0}/{1}", fi2.Numerator, fi2.Denominator);
Console.WriteLine("fi3 = {0}/{1}", fi3.Numerator, fi3.Denominator);
Console.WriteLine("fi4 = new Fraction(1, 0) provoque une DivideByZeroException");
Console.WriteLine("fi5 = {0}/{1}, créée avec 10/12", fi5.Numerator, fi5.Denominator);
Console.WriteLine("fi6 = {0}/{1}, créée avec 0.5", fi6.Numerator, fi6.Denominator);
Console.WriteLine("");

Fraction f1 = new Fraction(12, 42);
Fraction f2 = new Fraction(0.5);
Fraction f3 = new Fraction(-1, 2);

Console.WriteLine("f1 = {0}", f1);
Console.WriteLine("f2 = {0}", f2);
Console.WriteLine("f1 + f2 = {0}", f1.Add(f2));
Console.WriteLine("f1 / f2 = {0}", f1.Divide(f2));
Console.WriteLine("f1 - f2 = {0}", f1.Substract(f2));
Console.WriteLine("f1 * f2 = {0}", f1.Multiply(f2));
Console.WriteLine("f1 * f2 + f3 = {0}", f1.Multiply(f2).Add(f3));
Console.WriteLine("f1 < f2 : {0}", f1.CompareTo(f2));
Console.WriteLine("f2 > f1 : {0}", f2.CompareTo(f1));
Console.WriteLine("f1 == f1 : {0}", f1.CompareTo(f1));
Console.ReadLine();
