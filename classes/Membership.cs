using System;
using StayClass;
using RoomClass;
using StandardRoomClass;
using DeluxeRoomClass;
using GuestClass;

// Student Number : S10246045
// Student Name : Jonathan Ho

namespace MembershipClass
{
    public class Membership
    {
        // Create attributes for the Membership class
        // 1. status [string]
        // 2. points [int]
        public string status { get; set; }
        public int points { get; set; }


        // Empty Constructor
        public Membership()
        {
        }

        // Parameterized Constructor 
        public Membership(string aStatus, int aPoints)
        {
            status = aStatus;
            points = aPoints;
        }

        // Earn Points method
        // Remember to link Calculate total in Stay class
        public void EarnPoints(double totalCalculated)
        {
            // Calculate points earned
            // Total spending divided by 10, rounded to nearest whole 
            int totalPointsEarned = Convert.ToInt32(Math.Round(totalCalculated / 100));
            points += totalPointsEarned;

        }

        // Redeem points method -- <! Only silver and gold Members can offset their bill using points !>
        // Remember to link final price to stay


        // Final To string Method
    }
}

