using System;

namespace ParkingLot // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an empty list to store the cars in the parking lot
            List<string> parkingLot = new List<string>();
            int maxLot = 6;

            while (true)
            {
                Console.WriteLine("Welcome to the parking lot CLI! Please select an option:");
                Console.WriteLine("1. Park a car");
                Console.WriteLine("2. Remove a car");
                Console.WriteLine("3. List all cars in the parking lot");
                Console.WriteLine("4. Exit");

                // Get user input for the selected option
                int option = int.Parse(Console.ReadLine());

                // Perform the selected option
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the license plate number of the car:");
                        string licensePlate = Console.ReadLine();
                        if (parkingLot.Count < maxLot)
                        {
                            parkingLot.Add(licensePlate);
                            Console.WriteLine("Car parked successfully!");
                            Console.WriteLine("Allocated slot number:", parkingLot.Count);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, parking lot is Full!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter the license plate number of the car to remove:");
                        string removePlate = Console.ReadLine();
                        parkingLot.Remove(removePlate);
                        Console.WriteLine("Car removed successfully!");
                        break;
                    case 3:
                        Console.WriteLine("Cars in the parking lot:");
                        foreach (string car in parkingLot)
                        {
                            Console.WriteLine(car);
                        }
                        Console.WriteLine(parkingLot.Count);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option selected. Please try again.");
                        break;
                }
            }
        }
    }
}