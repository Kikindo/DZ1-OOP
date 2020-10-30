using ClassLibrary;
using System;


namespace Display
{
    class Display
    {
         
        static void Main(string[] args)
        {
            Episode ep1, ep2;

            ep1 = new Episode();
            ep2 = new Episode(2.45,6.78,3.45);
            int i;
            int viewers = 10;

            for (i = 0; i < viewers; i++)
            {
                ep1.AddView(ep1.RandViewerScore());

            }

            Console.WriteLine("Max score: " + ep1.MaxScore());

            if (ep1.AverageScore() > ep2.AverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.ViewerCount()}");   //Ovaj dio ako možete pojasniti kako da mi izbacuje ViewerCount jer mi prikazuje samo 0.
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.ViewerCount()}");  //Ovaj dio ako možete pojasniti kako da mi izbacuje ViewerCount jer mi prikazuje samo 0.
            }



        }
    }
}



