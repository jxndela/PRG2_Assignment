// Student Number : S10246045
// Student Name : Jonathan Ho
using System;
using MembershipClass;
using StayClass;
using RoomClass;
using DeluxeRoomClass;
using GuestClass;

namespace StandardRoomClass
{
    public class StandardRoom : Room
    {
        // Create attributes for class Standard Room -> child of Room
        public bool requireWifi { get; set; }
        public bool requireBreakfast { get; set; }

        // empty constructor
        public StandardRoom()
        {
        }

        // parameterized constructor 
        public StandardRoom(int aRoomNumber, string aBedConfiguration, double aDailyRate, bool aIsAvail)
        {
            roomNumber = aRoomNumber;
            bedConfiguration = aBedConfiguration;
            dailyRate = aDailyRate;
            isAvail = aIsAvail;
        }

        // Calculate Charges method

        // To string
    }

}