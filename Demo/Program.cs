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

            #region (Function)2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //int[] numbers = { 1, 2, 3 };
            //int result = sum(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            
            //int[] numbers = { 1, 2, 3 };
            //int result = sum(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);

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

        #region Q2)
        static int sum(ref int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {


                if (arr is not null)
                {
                    sum += arr[i];
                    arr = new int[3] { 100, 200, 300 };
                    for (int j= 0; j < arr.Length; j++)
                    {
                        sum += arr[j];


                    }
                }
            }
            return sum;
        }
        #endregion
    }
}
