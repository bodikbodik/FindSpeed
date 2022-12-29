using System;

namespace FindSpeed
{
    public static class Tasks
    {
        public static void Task1(double v, double u, double t1, double t2)
        {
            double distance = 0;

            distance = (v*t1) + ((v-u)*t2);


            Console.WriteLine(Math.Round(distance, 2));
        }

        public static void Task2(double s, double t, double v1, double v2)
        {
            double distance = 0;

            distance = (v1 * t) + (v2 * t) + s;
            
            Console.WriteLine(Math.Round(distance, 2)); 
        }
    }
}



