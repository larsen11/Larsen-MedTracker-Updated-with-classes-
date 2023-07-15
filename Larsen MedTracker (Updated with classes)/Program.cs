using System;

namespace Larsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Medicine Tracker by Larsen Reyes!");

            Console.Write("Enter the number of medicines you want to track: ");
            int numberOfMedicines = int.Parse(Console.ReadLine());

            MedicineTracker tracker = new MedicineTracker();

            for (int x = 0; x < numberOfMedicines; x++)
            {
                tracker.DetermineNumberOfMedicines();

                for (int i = 0; i < tracker.NumberOfDays; i++)
                {
                    string formattedDate = tracker.CurrentDate.ToString("dd/MM/yyyy");

                    for (int j = 1; j <= tracker.NumberOfTimes; j++)
                    {
                        Console.WriteLine($"{formattedDate}: Take {tracker.Medicines[tracker.MedicineNumber - 1].Name}");
                    }

                    tracker.CurrentDate = tracker.CurrentDate.AddDays(tracker.GapDays);
                }

                if (tracker.NumberOfDays == 0)
                {
                    Console.WriteLine("No medicine intake days found.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to run the program again or any other key to exit.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}