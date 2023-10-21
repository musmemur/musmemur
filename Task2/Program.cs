﻿using System;
namespace Task2
{
	class Program
	{
		static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите простой делитель, меньший N: ");
            int FirstPrimeDivisor = int.Parse(Console.ReadLine());
            Console.Write("Введите простой делитель, меньший N: ");
            int SecondPrimeDivisor = int.Parse(Console.ReadLine());
			Console.WriteLine(CountNumbers(num, FirstPrimeDivisor, SecondPrimeDivisor));

            Console.Write("Введите начало отсчёта високосных лет: ");
            int StartYear = int.Parse(Console.ReadLine());
            Console.Write("Введите конец отсчёта високосных лет: ");
            int FinishYear = int.Parse(Console.ReadLine());
            Console.WriteLine(CountLeapYears(StartYear, FinishYear));

            Console.Write("Введите коэффициент a уравнения прямой: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b уравнения прямой: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент c уравнения прямой: ");
            int c = int.Parse(Console.ReadLine());
            VectorParallelAndPerpendicular(a, b, c);

            Console.Write("Введите x первой точки прямой: ");
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите y первой точки прямой: ");
            double y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите x второй точки прямой: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите y второй точки прямой: ");
            double y2 = int.Parse(Console.ReadLine());
            Console.Write("Введите x третьей точки: ");
            double x3 = int.Parse(Console.ReadLine());
            Console.Write("Введите y третьей точки: ");
            double y3 = int.Parse(Console.ReadLine());
            Console.WriteLine(IntersectionPoint(x1, y1, x2, y2, x3, y3));
		}
		static int CountNumbers(int num, int FirstPrimeDivisor, int SecondPrimeDivisor)
		{
            return (((num-1) / FirstPrimeDivisor) + ((num-1) / SecondPrimeDivisor) 
			      - ((num-1) / (FirstPrimeDivisor * SecondPrimeDivisor)));
        }
		
		static int CountLeapYears(int StartYear, int FinishYear)
		{
			int CountLeapYearsInA = (StartYear / 4) - (StartYear / 100) + (StartYear / 400);
			int CountLeapYearsInB = (FinishYear / 4) - (FinishYear / 100) + (FinishYear / 400);
			int IsALeapYear = ( Convert.ToInt32(StartYear % 4 == 0) + Convert.ToInt32(StartYear % 100 == 0) 
							  + Convert.ToInt32(StartYear % 400 == 0) ) % 2;
			return CountLeapYearsInB - CountLeapYearsInA + IsALeapYear;
		}
		
		static void VectorParallelAndPerpendicular(int a, int b, int c)
		{
			Console.WriteLine("(" + (-b).ToString() + "; " + a.ToString() + ")");
			Console.WriteLine("(" + a.ToString() + "; " + b.ToString() + ")");
		}
		
		static string IntersectionPoint(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			double k1 = Math.Abs(y2-y1) / Math.Abs(x2-x1);
			double b1 = y1 - k1*x1;
			double k2 = (-1)/k1;
			double b2 = y3 - k2*x3;
			
			double x4 = (b2-b1)/(k1-k2);
			double y4 = k1*(x4)+b1;
			return $"({ x4.ToString()}; { y4.ToString()})";
		}
	}
}		