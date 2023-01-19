using System;
using MembershipClass;
using StayClass;
using RoomClass;
using StandardRoomClass;
using GuestClass;

namespace DeluxeRoomClass
{
    public class DeluxeRoom : Room
    {
        // Create attributes for class Deluxe Room -> child of Room
        public bool additionalBed { get; set; }

        // empty constructor 
        public DeluxeRoom()
        {
        }

        // Parameterized constructor 
        public DeluxeRoom(int aRoomNumber, string aBedConfiguration, double aDailyRate, bool aIsAvail)
        {
            roomNumber = aRoomNumber;
            bedConfiguration = aBedConfiguration;
            dailyRate = aDailyRate;
            isAvail = aIsAvail;

        }
    }
}
