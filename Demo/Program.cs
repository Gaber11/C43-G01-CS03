namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (Functions)1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example. 
            //When you pass a value type by value, a copy of the variable is passed to the method.
            //changes made to the parameter inside the method do not affect the original variable.
            //int num1 = 4;
            //int num2 = 5;

            //Console.WriteLine(num1); //4
            //Printvaluetype(num1); //7
            //Console.WriteLine(num1); //4 
            ////===============================
            //Console.WriteLine(num2);  //5
            //PrintRefrencetype(ref num2); //9
            //Console.WriteLine(num2);    //9


            #endregion




        }
        #region Q1)function
        //static void Printvaluetype(int num1)
        //{
        //    num1 = num1 + 3;
        //    Console.WriteLine(num1);
        //}
        //static void PrintRefrencetype(ref int num2)
        //{
        //    num2 = num2 + 4;
        //    Console.WriteLine(num2);
        //}
        #endregion

    }
}
