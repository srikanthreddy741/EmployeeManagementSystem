﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM");

int IS_FULL_TIME = 1;
Random random = new Random();
int empCheck = random.Next(0, 2);
if (empCheck == IS_FULL_TIME)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}