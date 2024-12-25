namespace Demo
{
    internal class Assignment
    {
        //public static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //} 
        //public static void Swap(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Calculate(int a, int b)
        //{ 
        //    int sum = a + b;
        //    int subtraction = a - b; 
        //    Console.WriteLine("Sum of two numbers: "+ sum);
        //    Console.WriteLine("Subtraction of two numbers: "+ subtraction);
        //}
        //public static bool IsPrime(int num) 
        //{ 
        //    if (num <= 1) return false; 
        //    for (int i = 2; i * i <= num; i++)
        //    { 
        //        if (num % i == 0) 
        //            return false;
        //    } 
        //    return true; 
        //}
        //public static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        //public static int CalculateFactorial(int n) 
        //{
        //    int result = 1; 
        //    for (int i = 1; i <= n; i++) 
        //    { 
        //        result *= i; 
        //    }
        //    return result; 
        //}
        static void Main(string[] args)
        {
            #region ِAssignment 5
            #region Q1
            //This is useful when you want to ensure that the original data remains unchanged after the method execution.
            //int a = 5;
            //int b = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            #endregion
            #region Q2
            //Useful when you want to ensure the method can't change the reference to point to a new object, but can still modify the object's internal state.
            //int a = 5;
            //int b = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a,ref  b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Q3
            //Console.Write("First number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Second number: ");
            //int num2 = int.Parse(Console.ReadLine()); 
            //Calculate(num1, num2);
            #endregion
            #region Q4
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int temp = number;
            //while (temp != 0)
            //{
            //    sum += temp % 10;
            //    temp /= 10;
            //}
            //Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            #endregion
            #region Q5
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine()); 
            //bool isPrime = IsPrime(number);
            //Console.WriteLine("Is the number prime -> "+isPrime);
            #endregion
            #region Q6
            //int[] numbers = { 1,2,3,4,5,6,7,8,9 };
            //int min = int.MaxValue; 
            //int max = int.MinValue;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"The maximum value in the array is: " + max);
            //Console.WriteLine($"The minimum value in the array is: " +min); 
            #endregion
            #region Q7
            //Console.Write("Enter a number  ");
            //int number = int.Parse(Console.ReadLine());
            //int factorial = CalculateFactorial(number);
            //Console.WriteLine("The factorial  is: "+factorial);
            #endregion
            #region Q8

            #endregion
            #endregion
        }
    }
}