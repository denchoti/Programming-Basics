using System;

namespace _19.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute; //часа на изпита в минути
            int arriveMinutes = arriveHour * 60 + arriveMinute; //часа на пристигане в минути


            if (arriveMinutes > examMinutes)
            {
                
                Console.WriteLine("Late");
                
                int late = arriveMinutes - examMinutes; 
                if (late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int lateHour = late / 60;
                    int lateMinute = late % 60;
                    Console.WriteLine($"{lateHour}:{lateMinute:D2} hours after the start");
                }
            }
            else if (arriveMinutes == examMinutes || examMinutes - arriveMinutes <= 30)
            {
                
                Console.WriteLine("On time");
                
                if (examMinutes - arriveMinutes <= 30 && examMinutes != arriveMinutes)
                {
                    Console.WriteLine($"{examMinutes - arriveMinutes} minutes before the start");
                }
            }
            else if (examMinutes - arriveMinutes > 30)
            {
                
                Console.WriteLine("Early");

                
                int early = examMinutes - arriveMinutes; 
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
                else  
                {
                    int earlyHour = early / 60;
                    int earlyMinute = early % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinute:D2} hours before the start");
                }


            }
        }
    }
}
