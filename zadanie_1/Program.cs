﻿Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num[0] == num[4] && num[1] == num[3])        
    Console.WriteLine("Число является палиндромом");
else
{
    Console.WriteLine("Число не является палиндромом");
}