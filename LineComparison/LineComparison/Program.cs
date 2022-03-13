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
        public static String compareTo(double l1, double l2)
        {
            if (l1 == l2)
            {
                return "Line1 and Line2 are Equal.";
            }
            else
            {
                if (l1 > l2)
                {
                    return "Line 1 is Bigger Than Line 2";
                }
                else
                {
                    return "Line 1 is Smaller Than Line 2";
                }
            }
        }

        public static void Main(String[] args)
        {

            LineComparisonProgram LC1 = new LineComparisonProgram();
            LineComparisonProgram LC2 = new LineComparisonProgram();

            //Getting Line Point from User Input
            LC1.getLinePoint();
            LC2.getLinePoint();

            //Getting Length of Lines in Variables
            double line1Length = LC1.getLengthOfLine();
            double line2Length = LC2.getLengthOfLine();


            //Displaying the Length of Lines
            Console.WriteLine("Length of Line1 : " + line1Length);
            Console.WriteLine("Length of Line2 : " + line2Length);

            //Checking the Equality or Smaller Length of Lines
            Console.WriteLine(compareTo(line1Length, line2Length));


        }

    }
}

