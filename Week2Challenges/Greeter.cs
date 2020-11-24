using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Challenges
{
    public class Greeter
    {

        public string Name { get; set; }

        public void getName ()
        {
            Console.WriteLine("Hello " + Name);
        }

        public void farewell ()
        {
            Console.WriteLine("Farewell " + Name);

        }


        public DateTime Date { get; set; }

        public void timeOfDay ()
        {

            int hour = Date.Hour;
            
            if (hour < 12)
            
            {
                Console.WriteLine("Good Morning");
            
            } else if (hour >= 12 || hour < 18 )
            
            {
                Console.WriteLine("Good Afternoon");
            
            } else
            
            {
                Console.WriteLine("Good Evening");
            
             }
            

        }
        
    }
}
