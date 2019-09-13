using System;

namespace inlämningsupg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            Random random = new Random();
            int rndtal = random.Next(1, 101);
            Console.WriteLine("skriv ett tal mellan 1 och 100");
            string strnr = Console.ReadLine();
            int tal = int.Parse(strnr);
            bool loop = true;
     
            while (loop == true) 
            {
                
                f++;
                if (rndtal > tal)
                {
                    Console.WriteLine("Din gissning är för låg, gissa igen");
                    strnr = Console.ReadLine();
                    tal = int.Parse(strnr);
                }

                else if (rndtal < tal)
                { 
                Console.WriteLine("Din gissning är för hög, gissa igen");
                    strnr = Console.ReadLine();
                    tal = int.Parse(strnr);
                }

                else
                {
                    Console.WriteLine("Grattis du gissade rätt");
                    Console.WriteLine("Du använde " + f + "försök för att lista ut talet");
                    loop = false;
                }



            }


        }
    }
}
