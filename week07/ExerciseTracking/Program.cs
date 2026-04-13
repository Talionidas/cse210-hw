using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("16 Okt 1996", 30, 6.1));
        activities.Add(new Cycling("20 Nov 1994", 60, 15.8));
        activities.Add(new Swimming("03 Dez 1993", 120, 80));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

//going of my pace for running, and random estimates I would see for cycling and swimming