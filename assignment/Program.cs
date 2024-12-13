﻿namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Variable Decliration
            //// DataType variableName
            //int number;
            ////allocate unintialized 4 bytes of memory
            ////Console.WriteLine(number); invalid
            //number = 10;
            ////Console.WriteLine(number);  10

            //int number2 = 20; //declare and initialize
            //Console.WriteLine(number2); 
            #endregion


            #region DataType (Value type) : Stack
            //// DataType (Value type) : Stack
            //// Declare Variable

            //int number;
            //// Allocate uninitialized 4 bytes of memory at stack
            //Int32 number2;
            //number2 = 10;
            //Console.WriteLine(number2); 
            #endregion


            #region DataType (Reference Type) : Heap
            //Point P01; // Reference type
            //// declare a variable of type Point
            ////Console.WriteLine(P01); invalid

            //P01 = new Point();
            //// allocate the number of required bytes fot the object at heap
            //// initialize the allocated bytes with default values of the dataType
            //// calll user defined constructor if exists
            //// assign the object address to the reference
            //Console.WriteLine(P01);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Point P02 = new Point();
            //P02.X = 10;
            //Console.WriteLine(P02);
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            //P01 = P02;

            //Console.WriteLine(P01); 
            #endregion


            #region Object
            //object o01;
            //// declare for reference from object

            //o01 = new object();
            //o01 = 1;
            //o01 = "Hello";
            //o01 = 1.2;
            //o01 = new Point();

            //Console.WriteLine(o01);

            //Console.WriteLine(o01.GetHashCode());

            //Point P01 = new Point();

            //P01.ToString();
            //P01.GetHashCode();
            //P01.GetType();
            //P01.Equals(P01); 
            #endregion

            #region Implicit and Explicit Casting
            //// Casting : Converting one type to another type
            //// 1. Implicit Casting
            //int x = 10;
            //double y = x; // Implicit Casting


            //// 2. Explicit Casting

            //double z = 10.5;
            //int a = (int)z; // Explicit Casting


            //long l = 1111111111111111111;
            //int i = (int)l; 
            #endregion


            #region Parse,Covert and TryParse
            // Parse : Function

            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            // Covert : Class
            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);


            // TryParse : Function
            //Console.WriteLine("Enter your age: ");
            //int age;
            //bool Flag = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine(age);
            //Console.WriteLine(Flag); 
            #endregion

            #region Fraction and Discard
            //int x = 10;
            //double y = 10.5;
            //float z = 10.5f;
            //decimal a = 10.5m;

            //long l = 1_111_111_111_111_111_111; discard 
            #endregion
        }
    }
}
