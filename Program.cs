using System;

namespace HW_02_04_20_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double side_1, side_2;
            Console.Write("Введите длину 1: ");
            side_1 = double.Parse(Console.ReadLine());
            Console.Write("Введите длину 2: ");
            side_2 = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(side_1,side_2);
            r.Out();
        }
    }
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2){
            this.side1 = side1;
            this.side2 = side2;

        }

        public void Out(){
            System.Console.Write("Area = "+Area+" ");
            System.Console.WriteLine("Perimetr = "+Perimetr);
        }


        public double Area{get{return AreaCalculator();}}
        public double Perimetr{get{return PerimeterCalculator();}}
        private double AreaCalculator()
        {
            return side1 * side2;           
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }


    }
}
