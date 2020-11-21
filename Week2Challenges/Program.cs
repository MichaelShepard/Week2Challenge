using System;

namespace Week2Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.Name = "Mike";

            greeter.getName();
            greeter.farewell();
           
            greeter.Date = new DateTime(1974, 7, 10, 7, 10, 24);
            greeter.timeOfDay();
        }
    }
}
