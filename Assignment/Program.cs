using System.Text;

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
            //Console.WriteLine("Enter Two Number : ");
            //int Num1 =int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());

            //int PowerResult=1;


            //for (int i = 1 ;i<=Num2; i++)
            //{

            //    PowerResult *=Num1;
            //}
            //Console.WriteLine(PowerResult);
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter Marks of five subjects:");
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    int sub = int.Parse(Console.ReadLine());
            //    sum += sub;
            //}
            //Console.WriteLine($"Total marks= {sum}");
            //Console.WriteLine($"Average Marks =  {sum / 5}");
            //Console.WriteLine($"Percentage ={sum / 5}");
            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            //Console.Write("Month Number: ");
            //int Num= int.Parse(Console.ReadLine());

            //switch (Num)
            //{
            //    case 1: Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2: Console.WriteLine("Days in Month: 28");
            //        break;
            //    case 3: goto case 1;
            //        break;
            //    case 4: Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 5: goto case 1;
            //        break;
            //    case 6: goto case 4;
            //        break;
            //    case 7: goto case 1;
            //        break;
            //    case 8: goto case 1;
            //        break;
            //    case 9: goto case 4;
            //        break;
            //    case 10:goto case 1;
            //        break;
            //    case 11:goto case 4;
            //        break;
            //    case 12:goto case 1;
            //        break;
            //}

            #endregion

            #region 12- Write a program to create a Simple Calculator.
            //Console.WriteLine("*********Welcome in Simple Calculator [+ , - , * , / ]*********");

            //Console.Write("Enter the operator: ");
            //char operat = char.Parse(Console.ReadLine());

            //while (operat=='+'|| operat == '-' || operat == '*' || operat == '/')
            //{

            //    Console.Write("Enter Number 1: ");
            //    int Num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Number 2: ");
            //    int Num2 = int.Parse(Console.ReadLine());
            //    if (operat == '+')
            //        Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
            //    else if (operat == '-')
            //        Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
            //    else if (operat == '*')
            //        Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2}");
            //    else if (operat == '/')
            //        Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
            //    Console.WriteLine("=========================================");
            //    Console.Write("Enter the operator: ");
            //     operat = char.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Invalid operator");
            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.WriteLine("Enter a string");
            string letter = Console.ReadLine();
            string reversed = "";
            for (int i = letter.Length-1; i >= 0; i--)
            {

                reversed += letter[i];


            }
            Console.Write($"Reversed letter :{reversed} ");




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
