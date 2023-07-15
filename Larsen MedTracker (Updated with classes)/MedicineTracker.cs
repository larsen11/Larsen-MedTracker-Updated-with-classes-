using System;

namespace Larsen
{
    public class MedicineTracker
    {
        public DateTime StartDate { get; set; }
        public int NumberOfTimes { get; set; }
        public int GapDays { get; set; }
        public DateTime CurrentDate { get; set; }
        public int MedicineCount { get; set; }
        public int MedicineNumber { get; set; }
        public int NumberOfDays { get; set; }
        public Medicine[] Medicines { get; set; }

        public MedicineTracker()
        {
            Medicines = new Medicine[]
            {
                new Medicine("Biogesic"),
                new Medicine("Melatonin"),
                new Medicine("Opthamax"),
                new Medicine("Bioflu"),
                new Medicine("Neozep Forte"),
                new Medicine("Advil"),
                new Medicine("Alaxan"),
                new Medicine("Cherifer"),
                new Medicine("Immunpro"),
                new Medicine("Fern-C")
            };
        }

        public void DetermineNumberOfMedicines()
        {
            Console.WriteLine();
            Console.WriteLine($"Medicine #{MedicineCount + 1}");

            Console.Write("Enter the starting date of your prescribed medicine (dd/MM/yyyy): ");
            StartDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Medicine Options:");

            for (int i = 0; i < Medicines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Medicines[i].Name}");
            }

            Console.Write("Choose a Medicine: ");
            MedicineNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Enter the number of days you need to drink {Medicines[MedicineNumber - 1].Name}: ");
            NumberOfDays = int.Parse(Console.ReadLine());

            Console.Write($"Enter the number of times you need to drink {Medicines[MedicineNumber - 1].Name} per day: ");
            NumberOfTimes = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of days gap between medicine intake: ");
            GapDays = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Dates to drink {Medicines[MedicineNumber - 1].Name}:");

            MedicineCount++;
        }
    }
}