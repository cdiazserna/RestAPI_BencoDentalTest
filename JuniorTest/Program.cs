﻿using JuniorTest;

Console.WriteLine("Hello, World!");
var result = Temperatures.bodyTamperature("Dr Arnold Bullock", 2);
foreach (var item in result)
{
    Console.Write($"{item}\t");
}

