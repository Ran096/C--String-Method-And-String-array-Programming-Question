/*using System;
using System.Globalization;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int val;
            bool found = false;
            int[] num = new int[10];
            for(i=0;i<10;i++)
            {
                num[i] = i; 
            }
            val = 5;

            foreach(int x in num)
            {
                Console.WriteLine("value Found" + x);
                if (x==val)
                {
                    
                    found = true;
                    break;
                }
            }
            if(found)
            {
                Console.WriteLine("value Found");
            }
        }
    }
}
// String Topic Using Method function 
using System;
using System.Globalization;

namespace Method
{
    class StringMethod
    {
        static void Main()
        {
            string str1 = "When it comes to .NET programming, C# is #1.";
            string str2 = "When it comes to .NET programming, C# is #1.";
            string str3 = "C# strings are powerful.";
            string strUp, strLow;
            int result, idx;
            Console.WriteLine("str1 String Print -" + str1);
            Console.WriteLine("Str1 String Lenght" + str1.Length);
            strUp = str1.ToUpper(CultureInfo.CurrentCulture);
            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("String is Upper Case\t" + strUp);
            Console.WriteLine("String is Lowercase\t" + strLow);

            Console.WriteLine();

            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            Console.WriteLine("\n");

            if (str1 == str2)
            {
                Console.WriteLine("Str1==str2");
            }
            else
            {
                Console.WriteLine("str1 != Str2");
            }
            if (str1 == str3)
            {
                Console.WriteLine("Str1==str3");
            }
            else
            {
                Console.WriteLine("str1 != Str3");
            }
            result = string.Compare(str1, str3, StringComparison.CurrentCulture);
            if(result==0)
            {
                Console.WriteLine("str1 and str3 is equal");
            }
            else if(result<0)
            {
                Console.WriteLine("Str1 is  Less then str3");
            }
            else
            {
                Console.WriteLine("str1 is greater then  str3");
            }
            Console.WriteLine();

            str2 = "One Two Three One";
            idx = str2.IndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of first occurrence of One: " + idx);
            idx = str2.LastIndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of last occurrence of One: "+idx);
        }
    }
}}

// write a Program Sub String  Display
using System;
namespace String
{
    class Substring
    {
        static void Main(string [] arge)
        {
            string orstr= "C# makes strings easy.";
            string substr = orstr.Substring(2, 15);
            Console.WriteLine("Or String " + orstr);
            Console.WriteLine("sub string " + substr);
        }
    }
}

//  Objects are passed by reference.
using System;

namespace ObjectRef
{
    class Object
    {
        public int a, b;
        public Object(int i, int j)
        {
            a = i;
            b = j;
        }
    
     public void Change(Object obj)
     {
        obj.a = obj.a + obj.b;
        obj.b = -obj.b;
     }
    }
    class ObjcetDome
    {
        static void Main(String [] are)
        {
            Object obj1 = new Object(25, 25);
            Console.WriteLine("Before Call Value A= " + obj1.a + " B =" + obj1.b);
            obj1.Change(obj1);
            Console.WriteLine("After Call Value A=" + obj1.a + " B =" + obj1.b);
        }
    }
}

//// Demonstrate params.
using System;
namespace ParameDemo
{
    class Test
    {
       public int MinVal(params int[] nums)
        {
            int m;
            if(nums.Length==0)
            {
                Console.WriteLine("Error No Value ");
                return 0;
            }
            m = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                if(nums[i] < m) 
                {
                    m = nums[i];
                }
               
               
            }
            return m;
        }
        class ParamsDemo
        {
         public static void Main()
            {
                Test obj =new Test();
                int min, a = 20, b = 30;
                min = obj.MinVal(a, b);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(a, b, 1);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(12, 14, 15, 18, 14, 19, 2, 58, 21, 95);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(51, 52, 54, 45, 95, 69, 65, 35);
                Console.WriteLine("Minimum value is " + min);
            }
        }
    }
}

//Use regular parameter with a params parameter.

using System;
namespace TeatParams
{
    class Test
    {
        public void ShowArrays(string msg, params int[] nums)
        {
            Console.WriteLine(msg + ": ");
            foreach(int i in nums)
            {
                Console.Write(i + ":");
            }
            Console.WriteLine();
        }
    }
    class ParamsDemo
    {
        public static void Main(String []array)
        {
            Test ob = new Test();
            ob.ShowArrays("Here are some integers ", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            ob.ShowArrays("Heare are Two Same Value", 20, 24, 21, 20);

        }
    }
}

// Return an object.

using System;
namespace ReturnObject
{
    class Rect
    {
        int heigth;
        int width;
        public Rect(int w, int h)
        {
            width = w;
            heigth = h;
        }
        public int Area()
        {
            return width * heigth;
        }
        public void show()
        {
            Console.WriteLine(width + ":" + heigth);
        }
        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, heigth * factor);// Create Returnig Object Syntex
        }
    }
    class ReturnObjectDemo
    {
        public static void Main(String[] ages)
        {
            Rect obj = new Rect(10, 15);
            Console.WriteLine("Dimensions Rect Obj");
            obj.show();
           
           
            int value = obj.Area();
            Console.WriteLine("Area is : " + value);

        }
    }
}
*/