using System;
using FindSpeed;

Console.WriteLine("Tests for your tasks");

Console.WriteLine("Task1");
Console.Write("V = 5.2, U = 2.1, T1 = 3.5, T2 = 1, Distance = ");
Tasks.Task1(5.2, 2.1, 3.5, 1);

Console.Write("V = 20.5, U = 5.2, T1 = 5, T2 = 2.5, Distance = ");
Tasks.Task1(20.5,5.2, 5, 2.5);

Console.Write("V = 15.2, U = 7.8, T1 = 1.25, T2 = 3.5, Distance = "); 
Tasks.Task1(15.2, 7.8, 1.25, 3.5);

Console.Write("V = 10.54, U = 3.7, T1 = 2.5, T2 = 5.25, Distance = ");
Tasks.Task1(10.54, 3.7, 2.5, 5.25);


Console.WriteLine("Task2");
Console.Write("S = 30.5, T = 2.5, V1 = 75.2, V2 = 90, Distance = ");
Tasks.Task2(30.5, 2.5, 75.2, 90);

Console.Write("S = 50.75, T = 5.5, V1 = 65.8, V2 = 90.2, Distance = ");
Tasks.Task2(50.75, 5.5, 65.8, 90.2);

Console.Write("S = 5.12, T = 1.25, V1 = 80.12, V2 = 60, Distance = "); 
Tasks.Task2(5.12, 1.25, 80.12, 60);

Console.Write("S = 10.23, T = 1.25, V1 = 70.54, V2 = 110, Distance = ");
Tasks.Task2(10.23, 1.25, 70.54, 110);

