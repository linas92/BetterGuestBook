﻿using GuestBookLibrary.Models;

/*
Capture the info about the guests (assumption is at least one guest and unknown maximum of guests)
Info to capture: First name, last name, message to the host
Once done, loop through each guests and print their info
*/

namespace BetterGuestBook
{
    internal class Program
    {            
        private static List <GuestModel> guests = new List <GuestModel> ();//I create a List instead of array because I don't know how many "guests" will attend (array is when i know the number of "guests")
        static void Main(string[] args)
        {
            PrintGuestInfo();
            GetGuestInformation(); 
        }
        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)// loop through the guest list
            {
                Console.WriteLine(guest.GuestInfo);// get the readonly string from the GuestModels (better practice as we don't re-write the information)
            }
        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = string.Empty;
            do // chose a do while loop, cuz I knew at least one guest is coming and this runs at least once
            {
                GuestModel guest = new GuestModel();// this represents ONE singular guests

                //should check if the input is "valid" but its no big deal, we can "assume"
                guest.FirstName = GetInforFromConsole("What is your first name?");

                guest.LastName = GetInforFromConsole("What is your last name?");

                guest.MessageToHost = GetInforFromConsole("What message would you like to tell your host?");

                moreGuestsComing = GetInforFromConsole("Are more guests coming? Yes/no");

                guests.Add(guest);// adding guest to the guests lists, else why it disappears

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");//runs as long as the answer is yes
        }
        private static string GetInforFromConsole(string input)
        {
            string output = string.Empty;
            Console.WriteLine(input);
            output = Console.ReadLine();

            return output;
        }
    }
}

