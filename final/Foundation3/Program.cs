using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("57-37 E CENTER ST", "MOAB", "UT", "84532", "United States");
        addresses[1] = new Address("1770 RED CLIFS dr", "ST GEORGE", "UT", "84790", "United States");
        addresses[2] = new Address("231 W 4500 S", "Murray", "UT", "84107", "United States");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("Moab Photography Retreat","Lecture and critique. Learn from each others images while they are projected for the group. Art will adjust them in Adobe Lightroom and provide instruction.","03/06/2024","10:00am",addresses[0],"DIANA from Art Wolfe Inc","35 People");
        events[1] = new OutdoorGatheringEvent("St. George Area Parade of Homes","The 2024 St. George Area Parade of Homes is no ordinary Parade. It is the largest Parade in the state featuring 25 new homes full of the extraordinary","26/02/2024","10:00am",addresses[1],"paradesmart");
        events[2] = new ReceptionEvent("Dance with Gabe in SLC","Join us for an exciting weekend full of Country swing dancing with the infamous Gabe Sebastian.!","03/01/2024","02:00pm",addresses[2],"infamousgabe@gmail.com");


        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N°: {i + 1}\n");
            Console.WriteLine("-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}