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

            //Console.WriteLine("Enter 3 Numbers: ");
            //int Num1=int.Parse(Console.ReadLine());
            //int Num2=int.Parse(Console.ReadLine());
            //int Num3=int.Parse(Console.ReadLine());
            //int MaxElement;
            //int MinElement;

            //MaxElement = Num1 > Num2 ? (Num1 > Num3 ? Num1 : Num3) : (Num2 > Num3 ? Num2 : Num3);
            //MinElement = Num1 < Num2 ? (Num1 < Num3 ? Num1 : Num3) : (Num2 < Num3 ? Num2 : Num3);


            //Console.WriteLine($"MaxElement= {MaxElement}");
            //Console.WriteLine($"MinElement= {MinElement}");





            #endregion

            #region 4-Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter Number to check If a number is even or odd: ");
            //int Num= int.Parse(Console.ReadLine());
            //if (Num % 2 == 0)
            //    Console.WriteLine("Even");

            //else
            //    Console.WriteLine("Odd");





            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter character : ");
            //char Char =char.Parse( Console.ReadLine());

            //if (Char == 'a' || Char == 'e' || Char == 'i' || Char == 'u' || Char == 'o')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");





            #endregion

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Enter Number : ");
            //int Num =int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Num; i++)
            //{
            //    Console.WriteLine(i);
            //}




            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i =1; i <= 12; i++)
            //{
            //    int multiplication = i * Num;

            //    Console.WriteLine(multiplication);
            //}
            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 1; i < Num; i++)
            //{
            //    if (i%2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            Console.WriteLine("Enter Two Number : ");
            int Num1 =int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            
            int PowerResult=1;
           

            for (int i = 1 ;i<=Num2; i++)
            {

                PowerResult *=Num1;
            }
            Console.WriteLine(PowerResult);
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
