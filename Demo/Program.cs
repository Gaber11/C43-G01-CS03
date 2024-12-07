using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace Demo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)        {

            #region 1-IF - Switch [Numeric Type 1]
            //A] Conditional statement [If, Switch till c# 6]
            //Example 1 [Numeric type: Equality] [Month in first quarter]
            //Console.WriteLine("Enter The number of month : ");
            //int MonthNum=int.Parse(Console.ReadLine());
            //if (MonthNum == 1)
            //    Console.WriteLine("jeunuary");
            //else if (MonthNum == 2)
            //    Console.WriteLine("Fereuary");
            //else if (MonthNum == 3) 
            //    Console.WriteLine("March");
            //else 
            //    Console.WriteLine("Not in Quarter one");
            //---> Switch
            //switch (MonthNum)
            //{
            //    case 1:
            //        Console.WriteLine("jeunuary");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fereuary");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Not in Quarter one");
            //        break;
            //}

            #endregion

            #region 2-IF-Switch [Numeric Type 2]
            //   Example 2[Numeric type: less than or greater than][Age of user]
            //Console.WriteLine("Enter Your Age: ");

            //int Age; 
            //int.TryParse(Console.ReadLine(), out Age);
            //if (Age > 22)
            //    Console.WriteLine("This user your Age is greater than 22");
            //else if (Age < 22)
            //    Console.WriteLine("This user your Age is lesser than 22");
            //else
            //    Console.WriteLine("This user your Age is 22");

            //switch (Age)
            //{
            //    case > 22:
            //        Console.WriteLine("This user your Age is greater than 22");
            //        break;

            //    case < 22:
            //        Console.WriteLine("This user your Age is lesser than 22");
            //        break;
            //    default:
            //        Console.WriteLine("This user your Age is 22");
            //        break;


            //}










            #endregion

            #region 3-IF-Switch [String Type]
            //Name of user
            //Console.WriteLine("Enter Your name: ");
            //string name= Console.ReadLine();

            //if (name == "Gaber")
            //    Console.WriteLine("Hello Gaber");
            //else if (name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (name == "Maha")
            //    Console.WriteLine("Hello Maha");
            //else if (name == "Yasser")
            //    Console.WriteLine("Hello Yasser");
            //else if (name == "Kareem")
            //    Console.WriteLine("Hello Kareem");
            //switch (name)
            //{
            //    case "Gaber":
            //        Console.WriteLine("Hello Gaber");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Yasser":
            //        Console.WriteLine("Hello Yasser");
            //        break;
            //    case "Kareem":
            //        Console.WriteLine("Hello Kareem");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;


            //}


            #endregion

            #region 4-Switch with goto [options]
            //Console.WriteLine("Enter Salary 1000 or 2000 or 3000");
            //int salary = int.Parse(Console.ReadLine()); 
            //switch(salary)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        //Console.WriteLine("Option 2");
            //        //Console.WriteLine("Option 1");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        //Console.WriteLine("Option 1");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //    defualt:
            //        Console.WriteLine("Invalid");
            //}
            #endregion

            #region 5-Switch in C# 7.0
            //object input;
            ////4 bytes in stack
            ////0 bytes in heap
            //// refer to null
            //input = new object();
            ////-------->NEW
            ////1]Allocate number of bytes needed in the heap
            ////2] Assign defualt value in heap [NULL]
            ////3] Call user defined constructor if exist
            ////4] Assign the refernce in stack to the obj in heap
            //input = 14;
            //switch (input)
            //{
            //    case int localInput when localInput >10 && localInput<15:
            //        Console.WriteLine($"integer input ==> {localInput}");
            //        break;
            //    case double localInput:
            //        Console.WriteLine("double input");
            //        break;
            //    case Person LocalInput:
            //        Console.WriteLine("Person input");
            //        break;
            //    default:
            //        break;

            //}








            #endregion

            #region 6-Switch in C# 8.0
            //Console.WriteLine("Enter an option [1 ,2, 3]");
            //string message;
            //string option=Console.ReadLine();

            //switch (option) {
            //    case "1":
            //        message = "option 1";
            //        break;
            //    case "2":
            //        message = "option 2";
            //        break;
            //    case "3":
            //        message = "option 3";
            //        break;
            //    defualt:
            //        message = "Invalid";
            //        break;

            //}
            //message = option switch
            //{
            //    "1"=>"option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(message);

            // Example 2 [Person]
            //Person person = new Person() { Id = 100, Name = "Gaber", Age = 25 };
            //switch (person)
            //    {
            //        case { Id: 100, Name: "Gaber", Age: 22 }:
            //            Console.WriteLine("Your name is Gaber and your age = 22");
            //            break;
            //        case { Age: 24 }:                
            //            Console.WriteLine("Your age is 24");
            //            break;
            //        default:
            //            Console.WriteLine("Your name is 8arib");
            //            break;
            //    }
            //string Message = person switch
            //{
            //    { Name : "Gaber" , Age:23 , Id:100}=> "Your name is Gaber and your age = 23",
            //    {Age: 24} => " your age = 24",
            //    _=> "Invalid"
            //};
            //Console.WriteLine(Message);

            #endregion

            #region 7-Switch in C# 9.0

            //     Example 2[Person]
            //Person person = new Person() { Id = 100, Name = "Gaber", Age = 30 };
            //switch (person)
            //{
            //    case { Id: 100, Name: "Gaber", Age:> 22 and <40 }:
            //        Console.WriteLine($"Your name is Gaber and your age = {person.Age}");
            //        break;
            //    case { Age: 24 }:
            //        Console.WriteLine("Your age is 24");
            //        break;
            //    default:
            //        Console.WriteLine("Your name is 8arib");
            //        break;
            //}

            //string Message = person switch
            //{
            //    { Name: "Gaber", Age:> 23 and <40, Id: 100 } => $"Your name is Gaber and your age = {person.Age}",
            //    { Age: 24 } => " your age = 24",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(Message);
            #endregion

            #region 8-Loop Statements[for-while-Do While-foreach]         

            //Console.WriteLine(10+10);
            //Console.WriteLine(20+10);
            //Console.WriteLine(30+10);
            //Console.WriteLine(40+10);
            //Console.WriteLine(50+10);
            //Console.WriteLine(60+10);
            //Console.WriteLine(70+10);
            //Console.WriteLine(80+10);
            //Console.WriteLine(90+10);
            //Console.WriteLine("*******************************");

            // for(int i =10; i <= 100; i+=10)
            // {
            //     Console.WriteLine(i);
            // }




            #endregion

            #region 9-For - Foreach
            //int[] number = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //foreach (int i in number)
            //{

            //    Console.WriteLine(i);

            //}




            #endregion

            #region 10-While - Do While
            //Console.WriteLine("Enter Even Number");
            //int num = int.Parse(Console.ReadLine());
            //while (num % 2 == 1)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    num = int.Parse(Console.ReadLine());

            //}
            //Console.Clear();
            //Console.WriteLine($"Even number is {num}");


            //int num;
            //bool flag;

            //do
            //{


            //    Console.WriteLine("Enter Even Number");
            //  flag= int.TryParse(Console.ReadLine(),out num);
            //} while (num % 2 == 1 || !flag);

            //Console.Clear();
            //Console.WriteLine($"Even number is {num}");

            //int i=0;
            ////do
            ////{
            ////    Console.WriteLine(i);
            ////    i++;
            ////}while (i<5);  

            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region 11-String
            //string Name1 = "Mariam";
            //string Name2 = "Amira";
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name2 = Name1;
            //Console.WriteLine("*************After = **:"); ;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name1 = "MariamYasser";
            //Console.WriteLine("****After Changing Name");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());

            // Example 2 [Message +=]
            //string Message = "Hello"; //Unreachable
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("** ***After Change:");

            //Message += " Mariam";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            #endregion

            #region 12-StringBuilder
            //StringBuilder --> is a reference type [Class]
            //Mutable
            //is a linkedList
            //StringBuilder Name1 = new StringBuilder("Gaber");
            //StringBuilder Name2 = new StringBuilder();
            //Name2.Append("Amira");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Console.WriteLine("***********");

            //Name2 = Name1;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode()); 
            //Console.WriteLine("*****");
            //Name1.Append(" eZZAT");
            ////============================
            //// StringBuilderMethods
            //Name1.AppendLine(" Yasser");
            //Name1.Append("Hello");
            ////Console.WriteLine(Name1);
            //Name1.Insert(0, "Hello ");
            //Name1.Remove(0, 5);
            //Console.WriteLine(Name1);
            //Console.WriteLine("*************************");
            //Name1.Replace("Hello", "HelloNew");
            //Console.WriteLine(Name1);


            #endregion

            #region 13-1D Array
            //int[] Num= new int[5];
            //Num [0] = 1;    
            //Num [1] = 2;
            //Num [2] = 3;
            //Num [3] = 4;
            //Num [4] = 5;
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    Console.WriteLine(Num [i]); 
            //}

            //int[]Numbers1 =  new int[] { 1, 2, 3,4 };
            //int[] Numbers2 = new int[5] { 1, 2, 3, 4,5 };
            //int[] Numbers3 = {1,2,3,4 };

            //for (int i = 0; i < Numbers3.Length; i++)
            //{
            //    Console.WriteLine(Numbers3[i]);
            //}




            #endregion

            #region 15-2D Array Part 1
            //int[,] marks = new int[3, 5];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Grade of student {i+1} ");

            //    for (int j = 0; j < 5; j++)
            //    {


            //        Console.WriteLine($"Enter the grade of subject {j + 1}");
            //        marks[i, j] = int.Parse(Console.ReadLine());



            //    }
            //    Console.WriteLine("==============================");

            //}
            //======================================================================
            //int[,] marks = new int[3, 5];
            //bool flag;
            //int Grade;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Grade of student {i + 1} ");

            //    for (int j = 0; j < 5;)
            //    {


            //        Console.WriteLine($"Enter the grade of subject {j + 1}");
            //        j = int.TryParse(Console.ReadLine(), out Grade) ? ++j : j;
            //        marks[i, j] = Grade;

            //    }

            //    Console.WriteLine("================هنا بعد ما بعمل أول طالب البرنامج بينتهي !==============");

            //}



            #endregion

            #region
        






            #endregion





        }
    }
}
