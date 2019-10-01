using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class anagram
    {


        static void Main(string[] args)
        {
            string word1 = "DIANA";
            string word2 = "INDIA";

            //char[] wrdChar1 = word1.ToLower().ToCharArray();
            //char[] wrdChar2 = word2.ToLower().ToCharArray();

            //Array.Sort(wrdChar1);
            //Array.Sort(wrdChar2);

            //string newWord1 = new string(wrdChar1);
            //string newWord2 = new string(wrdChar2);

            //if(newWord1==newWord2)
            //{
            //    Console.WriteLine("Anagram");
            //}
            //else
            //{
            //    Console.WriteLine("Not an anagram");
            //}
            //trying to add to githubklnlkjdff
            string aa = String.Concat(word1.OrderBy(a => a));
            string bb = string.Concat(word2.OrderBy(b =>b));

            if (aa == bb)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not an anagram");
            }


            Console.ReadLine();
        }
    }
}
