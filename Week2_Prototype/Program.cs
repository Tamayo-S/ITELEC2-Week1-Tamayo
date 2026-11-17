Reservation first = new Reservation("Chrissy Mae Luna", 101, 3);
Reservation second = new Reservation("Nick Portugal", 102, 2);

Console.WriteLine("=== HOTEL RESERVATION SYSTEM ===");

Console.WriteLine("\nFirst Reservation:");
Console.WriteLine("Guest: " + first.GuestName);
Console.WriteLine("Room: " + first.RoomNumber);
Console.WriteLine("Nights: " + first.NumberOfNights);

Console.WriteLine("\nExtending Chrissy's stay by 2 nights:");
Console.WriteLine(first.ExtendStay(2));
Console.WriteLine("Total Nights: " + first.NumberOfNights);

Console.WriteLine("\nCancelling Chrissy's reservation:");
first.Cancel();
Console.WriteLine("Cancelled: " + first.IsCancelled);

Console.WriteLine("\nTrying to extend cancelled reservation:");
Console.WriteLine(first.ExtendStay(1));

Console.WriteLine("\nSecond Reservation:");
Console.WriteLine("Guest: " + second.GuestName);
Console.WriteLine("Room: " + second.RoomNumber);
Console.WriteLine("Nights: " + second.NumberOfNights);

Console.WriteLine("\nExtending Nick's stay by 1 night:");
Console.WriteLine(second.ExtendStay(1));
Console.WriteLine("Total Nights: " + second.NumberOfNights);
