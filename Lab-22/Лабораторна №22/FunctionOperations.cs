using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Лабораторна__22
{
    internal class FunctionOperations
    {
        private int A;
        private int B;
        private double Interval;
        public FunctionOperations(int minimum=0, int maximum=1, double interval=0.1)
        {
            A = minimum;
            B = maximum;
            Interval = interval;
        }

        //Methods
        public bool descendingOrGrowingFunction()
        {
            bool result = true;
            double x = A;
            double previous;
            do
            {
                previous = x;
                x += Interval;
                if (x <= previous)
                {
                    result = false;
                    break;
                }
            } while (x <= B);
            return result;
        }
        public double[] maxAndMinOfFunction()
        {
            double[] result = new double[2];
            double minimum = A;
            double maximum = A;
            for(double x = A; x <= B; x += Interval)
            {
                if (maximum < x)
                    maximum = x;
                else if (minimum > x)
                    minimum = x;
            }
            result[0] = minimum;
            result[1] = maximum;
            return result;
        }
        public bool FunctionInOx()
        {
            bool result = false;
            for (double x = A; x <= B; x += Interval)
            {
                if(Math.Sqrt(x) * Math.Tan(x) == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public string morePointsInQuadrant()
        {
            double y = Math.Sqrt(A) * Math.Tan(A);
            int firstQuadrant = 0;
            int secontQuadrant = 0;
            int thirdQuadrant = 0;
            int fourthQuadrant = 0;
            for (double x = A; x <= B; x += Interval)
            {
                if (y>0&&x>0)
                    firstQuadrant++;
                else if (y> 0 && x < 0)
                    secontQuadrant++;
                else if (y< 0 && x < 0)
                    thirdQuadrant++;
                else if (y< 0 && x > 0)
                    fourthQuadrant++;
            }
            if (firstQuadrant > secontQuadrant)
            {
                if (firstQuadrant > thirdQuadrant)
                {
                    if (firstQuadrant > fourthQuadrant)
                        return "Перший квадрант";
                }
                else if (thirdQuadrant > fourthQuadrant)
                    return "Третій квадрант";
                else
                    return "Четвертий квадрант";
            }
            else if (secontQuadrant > thirdQuadrant)
            {
                if (secontQuadrant > fourthQuadrant)
                    return "Другий квадрант";
                else
                    return "Четвертий квадрант";
            }
            else if (thirdQuadrant > fourthQuadrant)
                return "Третій квадрант";
            else if (firstQuadrant > fourthQuadrant)
                return "Четвертий квадрант";
            return "Нема квадранту, у якому найбільше";
        }
        public double AverageFunction()
        {
            double sum = 0;
            double quantity = 0;
            for (double x = A; x <= B; x += Interval)
            {
                sum += Math.Sqrt(x) * Math.Tan(x);
                quantity ++;
            }
            return sum/quantity;
        }
        public string minFromPositive()
        {
            double result = 1000;
            for (double x = A; x <= B; x += Interval)
            {
                if (Math.Sqrt(x) * Math.Tan(x) > 0 && Math.Sqrt(x) * Math.Tan(x) < result)
                    result = Math.Sqrt(x) * Math.Tan(x);
            }
            if(result==1000)
                return "Нема додатних значень на даному проміжку";
            return $"Мінімальне значення серед додатних на даному проміжку: {result}";
        }
        public string maxFromNegative()
        {
            double result = -1000;
            for (double x = A; x <= B; x += Interval)
            {
                if (Math.Sqrt(x) * Math.Tan(x) < 0 && Math.Sqrt(x) * Math.Tan(x) > result)
                    result = Math.Sqrt(x) * Math.Tan(x);
            }
            if (result == -1000)
                return "Нема від'ємних значень на даному проміжку";    
            return $"Максимальне значення серед від'ємних на даному проміжку: {result}";
        }
        public double PointWhereFunctionInOx()
        {
            double result = 1000;
            double a = 0;
            double b = 0;
            for (double x = A; x <= B; x += Interval)
            {
                a = b;
                b = Math.Sqrt(x) * Math.Tan(x);
                if (b == 0)
                {
                    result = x;
                    break;
                }
                else if (a > 0 && b < 0 || a < 0 && b > 0)
                {
                    result = x - 0.05;
                }
            }
            return result;
        }
    }
}
