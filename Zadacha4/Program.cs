﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
int number = new int();
Console.WriteLine("Введите число: ");
 number = Convert.ToInt32(Console.ReadLine());

 if (number % 7 == 0 && number % 23 == 0 )
 {
    Console.WriteLine($"Число {number} кратно числу 7 и 23");
 }
 else
 {
    Console.WriteLine($"Число {number} не кратно числу 7 и 23");
 }