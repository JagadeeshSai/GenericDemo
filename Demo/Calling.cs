using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Demo
{
   public class Calling
    {
        public static void AreEqualMethod()
        {
            bool value = CoparisionCls.AreEqual1(123, 123);
            if (value)
                Console.WriteLine("true");
            else
                Console.WriteLine("False");

            bool strValue = CoparisionCls.AreEqual1("Jagadeesh", "Jagadeesh");
            if (strValue)
                Console.WriteLine("true");
            else
                Console.WriteLine("False");
        }

        public static void GenericEqual()
        {
            bool result = CoparisionCls.AreEqual2<int>(10, 12);
            if (result)
                Console.WriteLine("equal");
            else
                Console.WriteLine("Not Equal");
            
        }


    }
}
