using System;

namespace ifandifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool agree = true;
            if (agree)
            {
                Console.WriteLine("Agree");
                Console.WriteLine("With agree");
            }
            else
            {
                Console.WriteLine("Dis Agree");
                Console.WriteLine("With dis agree");
            } */
            int guess = 11;
            if(guess == 3){
                Console.WriteLine("three");
            }else if (guess == 1){
                Console.WriteLine("One");
            }else if (guess == 2){
                Console.WriteLine("Two");
            }else{
                Console.WriteLine("Invalid");
            }
        }
    }
}
