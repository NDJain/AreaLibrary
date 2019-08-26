using System;



namespace AreaLibrary
{
    public class Area
    {

        public double CalcArea(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public double CalcArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }
        // не до конца понял, для чего нужна проверка на прямоугольность (для возможного упрощения подсчёта площади треугольника?)


        public Boolean IsRA(double a, double b, double c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                return true;
            return false;
        }


    }
}
