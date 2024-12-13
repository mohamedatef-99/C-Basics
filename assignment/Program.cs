namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
