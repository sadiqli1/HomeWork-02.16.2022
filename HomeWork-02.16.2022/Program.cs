using System;

namespace HomeWork_02._16._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HeLlO wOrLd HoW aRe You";
            string newstr;
            foreach (char letter in str)
            {
                if (char.IsUpper(letter))
                { 
                    char.ToLower(letter);
                    string newstr = (string)letter.Clone;
                }
                else if (char.IsLower(letter))
                {
                    char.ToUpper(letter);
                    string newstr = (string)letter.Clone;
                }
                Console.WriteLine(newstr);
            }

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (letter=char.IsUpper(i))
            //    {

            //    }

            //}
        }
    }
}
