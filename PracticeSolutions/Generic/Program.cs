using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    //non - generic classes
    //public class MyGenericArray
    //{
    //    private int[] array;
    //    public MyGenericArray(int size)
    //    {
    //        array = new int[size];

    //    }

    //    public int getItem(int index)
    //    {
    //        return array[index];
    //    }

    //    public void setItem(int index,int value)
    //    {
    //        array[index] = value;
    //    }

    //}

        //generic classes
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }


    //generic Methods
    public class GenericMethod
    {
        public void swapInt(ref int lhs,ref int rhs)
        {
            int temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void swapChar(ref char lhs, ref char rhs)
        {
            char temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void swapGeneric<T>(ref T lhs1,ref T rhs1)
        {
            T temp;
            temp = lhs1;
            lhs1 = rhs1;
            rhs1 = temp;
        }

        public void swapGeneric1<T,U>(T value1,U value2)
        {
            Console.WriteLine(value1 +","+value2);
        }

        
    }


    class Program
    {
        static void Main(string[] args)
        {
            //instanciating class or declaring the array
            //MyGenericArray obj = new MyGenericArray(5);
            ////setting the values
            //for(int i=0;i<5;i++)
            //{
            //    obj.setItem(i, i * 5);
            //}

            ////retrieving the values
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(obj.getItem(i) + " ");
            //}

            //Generic class
            MyGenericArray<int> objIntArray = new MyGenericArray<int>(5);
            //setting the values
            for (int i = 0; i < 5; i++)
            {
                objIntArray.setItem(i, i * 5);
            }

            //retrieving the values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(objIntArray.getItem(i) + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Entering characters");
            //declaring a character array
            MyGenericArray<char> objCharArray = new MyGenericArray<char>(5);

            //setting the values
            for (int i = 0; i < 5; i++)
            {
                objCharArray.setItem(i, (char)(i + 97));
            }

            //retrieving the values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(objCharArray.getItem(i) + " ");
            }
            Console.WriteLine();
            //non-Generic method
            GenericMethod objMethod = new GenericMethod();
            int a = 10;
            int b = 20;
            char c = 'S';
            char d = 'M';

            Console.WriteLine("Values before swapping");
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("c={0},d={1}", c, d);

            objMethod.swapInt(ref a,ref b);
            objMethod.swapChar(ref c, ref d);

            Console.WriteLine("Values after swapping");
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("c={0},d={1}", c, d);


            //generic method
            Console.WriteLine("Values before swapping in Genreric");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("c={0},d={1}", c, d);

            objMethod.swapGeneric<int>(ref a, ref b);
            objMethod.swapGeneric<char>(ref c, ref d);

            Console.WriteLine("Values after swapping in Generic");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("c={0},d={1}", c, d);

            Console.WriteLine();
            Console.WriteLine("Generic with 2 methods");
            objMethod.swapGeneric1<int, string>(5, "Sachin");
            objMethod.swapGeneric1<int, int>(5, 6);
            Console.WriteLine();
            


            Console.ReadLine();


        }
    }
}
