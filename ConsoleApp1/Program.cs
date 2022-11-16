using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num01;       //zadané číslo
            string res01 = "";  //číslo zrcadlově
            
        
            Console.WriteLine("Enter your number:");        //zadání hodnoty pro kontrolu
            num01 = Convert.ToString(Console.ReadLine());

            

            if (num01 != "")    //kontrola, zda není prázdné
            {
                for (int i = num01.Length; i > 0; i--)
                {

                    res01 = res01 + num01[i - 1];   //převrácení čísla

                }

                if (num01 == res01)     //kontrola, zda je zrcadlově stejné
                {
                    Console.WriteLine(true);

                }
                else
                {
                    Console.WriteLine(false);
                }
                

            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
