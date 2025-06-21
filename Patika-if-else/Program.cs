using System;
Console.WriteLine("Lütfen bir sayı giriniz:  ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi < 0)
{
    Console.WriteLine("Sayı negatif.");
}
else if (sayi == 0)
{
    Console.WriteLine("Sayı sıfır.");
}
else
{
    Console.WriteLine("Sayı pozitif.");
}
if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}