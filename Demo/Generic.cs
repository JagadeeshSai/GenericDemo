using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Demo
{
    public static class CoparisionCls
    {
        public static void Init()
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

            bool result = CoparisionCls.AreEqual2<int>(10, 12);
            if (result)
                Console.WriteLine("equal");
            else
                Console.WriteLine("Not Equal");

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial2(5));
            Console.WriteLine(RecursiveFactorial(5));   //Recursive


            //Recursive
            // Call recursive method with two parameters.
            int count = 0;
            Console.WriteLine(Recursive(5, ref count));
            // Write the result from the method calls and also the call count.
            //int total = Recursive(5, ref count);
            //Console.WriteLine(total);
            Console.WriteLine("Number of iterarions/loops: ", count);

            RecursiveTest(5);

            ArrayCollectionApplication();

            HashTableClassApplication();

            StackApplication();

            SortedListApplication();

            QueueApplication();

            BitArrayClassApplication();

            GenericSwap<int>(5, 6);
            GenericSwap<char>('c', 'j');

            Console.ReadLine();
        }



        public static bool AreEqual1(object value1, object value2)
        {
            return value1 == value2;
        }

        // Generics used with collection 
        public static bool AreEqual2<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        static decimal Factorial(int n)
        {
            decimal result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static double Factorial2(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        // Recursive Function
        // n!=n*(n-1)*(n-2)*...*(n-(n-1)
        // 4!=4x(4-1)x(4-2)x(4-3)=24 
        public static double RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;
            return number * RecursiveFactorial(number - 1);//Recursive call    

        }

        public static double RecursiveFactorial(int number, ref int IntIteration)
        {
            IntIteration++;
            if (number == 0)
                return 1;
            return number * RecursiveFactorial(number - 1, ref IntIteration);//Recursive call    

        }

        static int Recursive(int value, ref int count)
        {
            count++;
            if (value >= 10)
            {
                // throw new Exception("End");
                return value;
            }
            return Recursive(value + 1, ref count);
        }

        public static int RecursiveTest(int intParameter)
        {
            Console.WriteLine(intParameter);
            return (intParameter == 0) ? 0 : RecursiveTest(intParameter - 1); // + intParameter;
        }

        public static void ArrayCollectionApplication()
        {
            //It represents ordered collection of an object that can be indexed individually.
            Console.WriteLine("***** Array List  *****");
            ArrayList al = new ArrayList();

            al.Add(12);
            al.Add(56);
            //al.Add(20.25);
            al.Add(10);

            Console.WriteLine("Array List Capacity: {0} ", al.Capacity);
            Console.WriteLine("Array List Count: {0}", al.Count);
            //Console.WriteLine("Array List Sorting: ", al.Sort);
            int intIteration = 0;
            foreach(int i in al)
            {
                intIteration++;
                Console.WriteLine("Elements in Array List: {0}, Iteration {1} ", i, intIteration);
            }
        }

        public static void HashTableClassApplication()
        {
            // The Hashtable class represents a collection of key-and-value pairs
            Console.WriteLine("***** Hash Table  *****");
            Hashtable ht = new Hashtable();

            ht.Add("001", "Jagadeesh");
            ht.Add("002", "Gangadish");
            ht.Add("003", "Abdulla");

            ICollection hk = ht.Keys;

            foreach(string k in hk)
            {
                Console.WriteLine(k+ " Key & Value " +ht[k]);
            }          

        }

        public static void SortedListApplication()
        {
            Console.WriteLine("***** Sorted  *****");
            // It uses a key as well as an index to access the items in a list. A sorted list is a combination of an array and a hash table.
            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
        }

        public static void StackApplication()
        {
            // It represents a last-in, first out collection of object
            Console.WriteLine("***** Stack  *****");
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }

        public static void QueueApplication()
        {
            // It represents a first-in, first out collection of object.
            // When you add an item in the list, it is called "enqueue", and when you remove an item, it is called "deque".

            Console.WriteLine("***** Queue  *****");

            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
        }


        public static void BitArrayClassApplication()
        {
            // The BitArray class manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0).
            Console.WriteLine("***** Bit Array  *****");
            Console.WriteLine();
            //creating two  bit arrays of size 8
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);

            byte[] a = { 60 };
            byte[] b = { 13 };

            //storing the values 60, and 13 into the bit arrays
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            //content of ba1
            Console.WriteLine("Bit array ba1: 60");

            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6} ", ba1[i]);
            }
            Console.WriteLine();

            //content of ba2
            Console.WriteLine("Bit array ba2: 13");

            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6} ", ba2[i]);
            }
            Console.WriteLine();
            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();
            ba3 = ba1.Or(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after OR operation: 61");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();
        }

        public static void GenericApplication()
        {

        }

        static void GenericSwap<T>(T lhs, T rhs)
        {
            Console.WriteLine("***** ....  Swap using Generics  ...");
            Console.WriteLine();
            //display values before swap:
            Console.WriteLine("Int/Char/String/Decimal values before calling swap:");
            Console.WriteLine("lhs = {0}, rhs = {1}", lhs, rhs);
            
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
            Console.WriteLine();
            //display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("lhs = {0}, rhs = {1}", lhs, rhs);
        }
    }
            
}
