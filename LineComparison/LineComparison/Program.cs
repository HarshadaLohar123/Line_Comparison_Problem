using System;

namespace LineComparison
{

    public class LineComparisonProgram
    {
        //Variables for Line Points
        int x1, x2, y1, y2;


        //Method to Get Input from User
        public void getLinePoint()
        {
            Console.WriteLine("Enter The Value of X1 :");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Value of Y1 :");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Value of X2 :");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Value of Y2 :");
            y2 = int.Parse(Console.ReadLine());
        }

        //Method to Calculate Length of Line
        public double getLengthOfLine()
        {
            double lengthofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lengthofLine;
        }

        public static void Main(String[] args)
        {
            //Object of LineComaprison Class for Calculating Length of Lines
            LineComparisonProgram LC = new LineComparisonProgram();
            LC.getLinePoint();
            Console.WriteLine("Length of Lines : " + LC.getLengthOfLine());
        }

    }
}

