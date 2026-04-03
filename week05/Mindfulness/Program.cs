using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        int option = 0;
        int duration;

        while (option != 4)
        {
            Console.WriteLine("Menu Options:");

            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity ");
            Console.WriteLine("\t3. Start Listing Activity ");
            Console.WriteLine("\t4. Quit ");


            if (breathingActivity.GetActivityUses() > 0 || reflectingActivity.GetActivityUses() > 0 || listingActivity.GetActivityUses() > 0)
            Console.WriteLine($"Activities Done: Breathing: {breathingActivity.GetActivityUses()} | Reflecting: {reflectingActivity.GetActivityUses()} | Listing: {listingActivity.GetActivityUses()} ");
            Console.Write("Select an option from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Clear();
                breathingActivity.DisplayStartMessage();
                duration = int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(duration);
                Console.Clear();

                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                breathingActivity.AddUse();
                Console.Clear();

            }
            else if(option == 2)
            {
                Console.Clear();
                reflectingActivity.DisplayStartMessage();
                duration = int.Parse(Console.ReadLine());
                reflectingActivity.SetDuration(duration);
                Console.Clear();

                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                reflectingActivity.AddUse();
                Console.Clear();

            }
            else if(option == 3)
            {
                Console.Clear();
                listingActivity.DisplayStartMessage();
                duration = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(duration);
                Console.Clear();

                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                listingActivity.AddUse();
                Console.Clear();
            }
            else if (option == 4)
                break;

        }



    }
}