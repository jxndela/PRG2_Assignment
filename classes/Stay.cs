// Student Number : S10246045
// Student Name : Jonathan Ho
using System;
using MembershipClass;
using DeluxeRoomClass;
using RoomClass;
using StandardRoomClass;
using GuestClass;

namespace StayClass
{
    public class Stay
    {
        // Create attributes for the class Stay
        public DateTime checkinDate { get; set; }
        public DateTime checkoutDate { get; set; }
        public List<Room> roomList { get; set; }

        // Empty Constructor
        public Stay()
        {
        }

        // Parameterized Constructor
        public Stay(DateTime aCheckinDate, DateTime aCheckoutDate)
        {
            checkinDate = aCheckinDate;
            checkoutDate = aCheckoutDate;
            // Room list is empty when a new object Stay is being constructed 
            roomList = new List<Room>();
        }

        // Add Room method
        public void AddRoom(Room aRoom)
        {
            roomList.Add(aRoom);
        }

        // Calculate total method UNFINISHED
        public void CalculateTotal() { }
        // insert math

    }
}

