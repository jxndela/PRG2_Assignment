using System;
using MembershipClass;
using StayClass;
using RoomClass;
using StandardRoomClass;
using DeluxeRoomClass;
// Student Number : S10246045
// Student Name : Jonathan Ho

namespace GuestClass
{
    public class Guest
    {
        // Create attributes for Guest Class 
        public string name { get; set; }
        public string passportNum { get; set; }
        public Stay hotelStay { get; set; }
        public Membership member { get; set; }
        public bool IsCheckedIn { get; set; }

        // Empty constructor
        public Guest()
        {
        }
        // Parameterized constructor
        public Guest(string aName, string aPassportNum, Stay aHotelStay, Membership aMember)
        {
            name = aName;
            passportNum = aPassportNum;
            hotelStay = aHotelStay;
            member = aMember;
            // Before someone is checked in , always assume that they have not been checked in yet
            IsCheckedIn = false;
        }
    }
}
