// PRG2 Assignment 1 (Main Program)
//============================
// Student Number : S10246045
// Student Name : Jonathan Ho
//============================

// Using C# classes for relevant objects
using DeluxeRoomClass;
using GuestClass;
using MembershipClass;
using RoomClass;
using StandardRoomClass;
using StayClass;

// Basic Features (Methods)
// 1. List all Guest
static void listAllGuests()
{
    foreach (Guest in GuestList){}
}


// 2. List all Available Rooms 
// 3. Register Guest
// 4. Check-in Guest
// 5. Display stay details of a guest 
// 6. Extends the stay by number of days

// Program Execution 
// 1. Read the files Guest.csv, Rooms.csv, Stays.csv
// 2. Initialize the objects from the csv files by looping through constructors
// 3. Initialize the UI prompting the hotel staff with the basic & advanced features
// 4. Process the requests accordingly. 
// 5. Exit the program through the option in the main menu 

class Test
{
    public static void Main()
    {
        try
        {
            // using stream reading
            using (StreamReader sr = new StreamReader("Guests.csv"))
            {
                string line = sr.ReadLine();

            }
        }
    }
}