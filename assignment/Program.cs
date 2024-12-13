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

            #region Q1
            //Console.WriteLine("enter number:");
            //int number;
            //bool flag = int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine("number is : " + number);
            //Console.WriteLine("Flag : " + flag);
            #endregion

            #region Q2
            //Console.WriteLine("Enter String: ");
            //int number01 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number is : " + number01);
            // if it number it will print the number
            // if it string it will throw an exception 
            #endregion

            #region Q3
            //float number01 = 1.5f;
            //float number02 = 2.5f;

            //float sum = number01 + number02;
            //Console.WriteLine(sum); 
            #endregion

            #region Q4
            //Console.WriteLine("Enter string : ");
            //string str = Console.ReadLine();
            //string subStr = str.Substring(0, 4);  // Substring(startIndex, length)
            //Console.WriteLine(subStr); 
            #endregion

            #region Q5
            //int number01 = 10;
            //int number02 = number01;
            //Console.WriteLine(number01); // 10
            //Console.WriteLine(number02); // 10
            //number01 = 20;
            //Console.WriteLine(number01); // 20
            //Console.WriteLine(number02); // 10 
            #endregion

            #region Q6
            //Point P01 = new Point();
            //Console.WriteLine(P01.X); // 0
            //Console.WriteLine(P01.Y); // 0

            //Point P02 = P01;
            //Console.WriteLine(P02.X); // 0
            //Console.WriteLine(P02.Y); // 0

            //P01.X = 10;
            //Console.WriteLine(P01.X); // 10   
            //Console.WriteLine(P02.X); // 10 
            #endregion

            #region Q7
            //Console.WriteLine("Enter String one : ");
            //string str01 = Console.ReadLine();
            //Console.WriteLine("Enter String two : ");
            //string str02 = Console.ReadLine();
            //string str03 = str01 + str02;
            //Console.WriteLine(str03); 
            #endregion

            #region Q8
            //Console.WriteLine("Enter principal amount : ");
            //int principal;
            //bool flag = int.TryParse(Console.ReadLine(), out principal);
            //Console.WriteLine("prinicpal is : " + principal);

            //Console.WriteLine("Enter rate of interest : ");
            //int rate;
            //bool flag01 = int.TryParse(Console.ReadLine(), out rate);
            //Console.WriteLine("rate is : " + rate);

            //Console.WriteLine("Enter time : ");
            //int time;
            //bool flag02 = int.TryParse(Console.ReadLine(), out time);
            //Console.WriteLine("time is : " + time);

            //int Interest = (principal * rate * time) / 100;
            //Console.WriteLine("Interest is : " + Interest); 
            #endregion

            #region Q9
            //Console.WriteLine("enter weight: ");
            //double weight;
            //bool flag = double.TryParse(Console.ReadLine(), out weight);
            //Console.WriteLine("weight is : " + weight);

            //Console.WriteLine("Enter height : ");
            //double height;
            //bool flag01 = double.TryParse(Console.ReadLine(), out height);
            //Console.WriteLine("height is : " + height);

            //double BMI = weight / (height * height);
            //Console.WriteLine("BMI is : " + BMI); 
            #endregion

            #region Q10
            //Console.WriteLine("enter the temp : ");
            //int temp;
            //bool flag = int.TryParse(Console.ReadLine(), out temp);
            //Console.WriteLine("temp is : " + temp);
            //string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine("the temp is : " + result); 
            #endregion

            #region Q11
            //Console.WriteLine("Enter date : ");
            //DateTime date;

            //bool flag = DateTime.TryParse(Console.ReadLine(), out date);

            //Console.WriteLine($"format : {date:dd , MM , yyyy}");
            //Console.WriteLine($"format : {date:dd / MM / yyyy}");
            //Console.WriteLine($"format : {date:dd - MM - yyyy}"); 
            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// output : The event is on 06/14/2024 
            #endregion

            #region Q13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d); // 1
            //// f)	A value 1 will be assigned to d. 
            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //// output : 6 1 
            #endregion

            #region Q15
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //// output : 7 7 
            #endregion
        }
    }
}
