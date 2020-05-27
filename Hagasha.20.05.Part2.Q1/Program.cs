using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha._20._05.Part2.Q1
{
    class Program
    {


        static void Main(string[] args)
        {

            int[] firstArray = null;
            int[] secondArray = null;
            int a = 5;
            RandomArrays(out firstArray, out secondArray);

            Measure(ref firstArray, ref secondArray);

        }

        static int  Measure(ref int[] a, ref int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {

            }
            return 0;
        }

        //creating 2 arrays with random length and random numbers
        static void RandomArrays(out int[] firstArray, out int[] secondArray)
        {
 
            Random generator = new Random();

            firstArray = new int[generator.Next(1,11)];
            secondArray = new int[generator.Next(1,11)];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = generator.Next(generator.Next(1, 101));
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = generator.Next(generator.Next(1, 101));
            }

            foreach (int i in firstArray)
            {
                Console.WriteLine(i+"a");
                Console.ReadLine();
            }

            foreach (int i in secondArray)
            {
                Console.WriteLine(i+"b");
                Console.ReadLine();
            }
        }
        static void ComparingArrays()
        {
            
        }
    }
}
