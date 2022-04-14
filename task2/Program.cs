int numberA = 392;
int numberB = 433;
int numberC = 538;
int max;
if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if (numberC > max) max = numberC;
Console.Write($"наибольшее число - {max} ");