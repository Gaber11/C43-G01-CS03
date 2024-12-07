namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no

            //  Console.WriteLine("Enter Number");
            //  int Num = int.Parse(Console.ReadLine());
            // if (Num % 4 == 0 && Num % 3 == 0)
            //      Console.WriteLine("Yes");

            //else
            //      Console.WriteLine("No");


            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter Number to know if it positive or negative:");
            //int Num = int.Parse(Console.ReadLine());

            //string result = Num <0 ? "negative" :"Positive";
            //Console.WriteLine(result);

            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            Console.WriteLine("Enter 3 Numbers: ");
            int Num1=int.Parse(Console.ReadLine());
            int Num2=int.Parse(Console.ReadLine());
            int Num3=int.Parse(Console.ReadLine());
            int MaxElement;
            int MinElement;

            MaxElement = Num1 > Num2 ? (Num1 > Num3 ? Num1 : Num3) : (Num2 > Num3 ? Num2 : Num3);
            MinElement = Num1 < Num2 ? (Num1 < Num3 ? Num1 : Num3) : (Num2 < Num3 ? Num2 : Num3);


            Console.WriteLine($"MaxElement= {MaxElement}");
            Console.WriteLine($"MinElement= {MinElement}");





            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

        }
    }
}
