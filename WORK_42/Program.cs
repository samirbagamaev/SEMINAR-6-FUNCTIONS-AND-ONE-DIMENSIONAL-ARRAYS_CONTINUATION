// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string Change(int decimalNumber)
{
    var binaryNumber = string.Empty;
    while (decimalNumber > 0)
    {
        binaryNumber = (decimalNumber % 2) + binaryNumber;
        decimalNumber /= 2;
    }
    return binaryNumber;
}

Console.Write("ВВЕДИТЕ ЧИСЛО В ДЕСЯТИЧНОЙ СИСТЕМЕ: ");
var decimalNumber = Convert.ToInt32(Console.ReadLine());
var binaryNumber = Change(decimalNumber);

Console.WriteLine($"ЧИСЛО {decimalNumber} В ДЕСЯТИЧНОЙ СИСТЕМЕ СЧИСЛЕНИЯ - {binaryNumber}");