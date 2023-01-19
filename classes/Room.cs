using System;
using MembershipClass;
using StayClass;
using DeluxeRoomClass;
using StandardRoomClass;
using GuestClass;

// Student Number : S10246045
// Student Name : Jonathan Ho

namespace RoomClass
{
    public class Room
    {
        // Create attributes for the class Room
        public int roomNumber { get; set; }
        public string bedConfiguration { get; set; }
        public double dailyRate { get; set; }
        public bool isAvail { get; set; }

        // Empty Constructor
        public Room()
        {
        }

        // Parameterized Constructor 
        public Room(int aRoomNumber, string aBedConfiguration, double aDailyRate, bool aIsAvail)
        {
            roomNumber = aRoomNumber;
            bedConfiguration = aBedConfiguration;
            dailyRate = aDailyRate;
            isAvail = aIsAvail;
        }

        // CalculateCharges 

        // To string


    }
}