﻿using System;
using System.Reflection.Emit;

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

            #region

            #endregion

            #region

            #endregion

            #region

            #endregion


        }
    }
}
