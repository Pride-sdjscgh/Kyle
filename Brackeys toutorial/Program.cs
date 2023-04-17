using System;

namespace Brackeys_toutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console appearance///////////////////////
            Console.Title = "Kyle";
            Console.ForegroundColor = ConsoleColor.Green;
            /////////////////////////////////////////////
        

            // Conversation starts now
            Console.WriteLine("Sup BITCH");
            Console.ReadLine();
            Console.WriteLine("Wanna see something cool?\nIf not, then get out");
            Console.ReadLine();
            Console.WriteLine("Yes, you stayed\n OK OK [YES he fucking STAYED]\nAm going to tell a story,");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("and You better FUCKING STAY!!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-\n-\n-\n-\n-\n-\n-");
            Console.WriteLine("If your......");
            string yourSomething = Console.ReadLine();
            Console.WriteLine("....can cook......");
            Console.ReadLine();
            Console.WriteLine("....can protect you from......");
            string yourFear = Console.ReadLine();
            
            Console.WriteLine("....and can buy......");
            Console.ReadLine();
            Console.WriteLine("Then thats not your " + yourSomething);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("thats your MOM");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HAHAHAHAHAHAHAHAHAHAHAHAHA\nhoHAAAAAHAHAHAHAH\nhmmm hmmm hahaha");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("That is a good one.");
            Console.WriteLine("-\n-\n-\n-\n-\n-\n-");
            Console.WriteLine("Are you really scared of " + yourFear);
            Console.WriteLine("Bro you really need Help");
            Console.ReadLine();
            Console.ReadLine();

            int num1;
            int num2;
            int num3;
            int num4;
            int ans;
            int mainresult;
            Console.WriteLine("Ok Ok, sorry for the insult");
            Console.ReadLine();
            Console.WriteLine("Let me make it up to you........by showing you how smart you are");
            Console.ReadLine();
            Console.WriteLine("OK, lets go...");
            Console.ReadLine();

            Console.WriteLine("Ok, now give me a number: ");
            num1 = Convert.ToInt16( Console.ReadLine());

            Console.WriteLine("Another; ");
            num2 = Convert.ToInt16( Console.ReadLine() );

            Console.WriteLine("One more; ");
            num3 = Convert.ToInt16( Console.ReadLine() );

            Console.WriteLine("Ok, I promise this is the last one; ");
            num4 = Convert.ToInt16( Console.ReadLine() );

            ans = num1 * num2 * num3 * num4;
            mainresult = ans / 4;
            Console.WriteLine("By the numbers you gave me, the average number of braincells you have is");
            Console.WriteLine(mainresult);


            // wait before closing
            Console.ReadKey();
        }
    }
}
