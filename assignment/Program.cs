namespace assignment
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


            


        }
    }
}
