using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo

//public static void PrintShape(int count, string pattern)
//{
//    for (int i = 0; i < count; i++) {
//        Console.WriteLine(pattern);
//    } 
{
    internal class Demo
    {
        #region Demo
        #region Casting
        //object obj = new object();
        //obj = "mostafa";
        //obj = 3;
        //int x = 10;
        //object obj01 = new object();
        //obj01 = x;
        //Console.WriteLine(x);
        //object obj02 = new object();
        //obj02 = 10;
        //int x = (int)obj02;
        #endregion
        #region Nullable DataType
        //int x = null;
        //int? x = null;
        //Nullable<int> number;
        //int?  x =10;
        //int y =(int) x;
        //int y;
        //if (x != null)
        //{
        //    y = (int)x;
        //}
        //else {
        //    y = 0;
        //}
        //int y;
        //if (x.HasValue)
        //{
        //    y =x.Value;
        //}
        //else {
        //    y = 0;
        //}
        //y = HasValue ? x.Value : 0;
        //Console.WriteLine("y");
        #endregion
        #region Refrence
        //string? name = null;
        //Console.WriteLine(name);
        #endregion
        #region Null Propagation Operator
        //int[] numbers = { 1, 2, 3, 4, 5 };
        //if (numbers != null)
        //{
        //    for (int i = 0; numbers != null && i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
        //int length = numbers?.length ? 0 ;
        //Console.WriteLine(length);
        //Employee EMP = new Employee();

        //if (Employee!=null)
        //{
        //    if (EMP.DEpartment != null)
        //    {
        //        Console.WriteLine(EMP.Department.Name);
        //    }
        //}
        //Console.WriteLine(EMP?.Department?.Name??"Not Found");
        #endregion
        #region Functions
        //PrintShape(10, "*_*");
        //Console.WriteLine("Hello \n Mostafa Welcome To\t Route ");
        //PrintShape(10, "/*\\");
        #endregion
        #region Value type Parameters
        #region by value
        //int a = 5;
        //int b = 9;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Swap(a, b);
        //Console.WriteLine(a);
        //Console.WriteLine(b); 
        #endregion
        #region by ref
        //int a = 5;
        //int b = 9;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Swap(ref a,ref  b);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        #endregion
        #region Reference Type
        #region By Value
        //int[] Numbers = { 1, 2, 3 };
        //Console.WriteLine(SumArray(Numbers));
        //Console.WriteLine(Numbers[0]);

        #endregion
        #endregion
        #region Ex02
        #region By Value 
        //int[] Numbers = { 1, 2, 3 };
        //Console.WriteLine(SumArray(Numbers));
        //Console.WriteLine(Numbers[0]);

        #endregion

        #region By Reference

        //int[] Numbers = { 1, 2, 3 };
        //Console.WriteLine(ref Numbers);
        //Console.WriteLine(Numbers[0]);

        #endregion

        #endregion
        #region Functions - Passing By Out
        //int A = 10;
        //int B = 20;
        ////int Sum, Mul;
        //int Sum = 0 , Mul = 0 ; 
        ////SumMul(A, B, out Sum,out Mul);
        //SumMul(A, B, ref Sum,ref Mul);

        //Console.WriteLine(Sum);
        //Console.WriteLine(Mul);
        #endregion
        #region Functions - Parms

        //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        //int A = 10, B = 20, C = 30;
        //Console.WriteLine("A : {0} , B : {1} , C : {2}", A, B, C);

        #endregion
        #endregion
    }
    #endregion
    
}
