using System.ComponentModel.Design;

namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your profile:");
            UserProfile Jon = new UserProfile("Jon", 25, "Male", "Elektroingeniør", "Bergen");
            Jon.PrintUser();
            Console.WriteLine();

            Console.WriteLine("Friend suggestions:");
            OtherProfiles Kate = new OtherProfiles("Kate", 42, "Female", "Nurse", "Oslo");
            Kate.PrintOtherProfiles();
            Console.WriteLine();

            OtherProfiles Marcus = new OtherProfiles($"Marcus", 32, "Male", "Sales", "Oslo");
            Marcus.PrintOtherProfiles();
            Console.WriteLine();

            OtherProfiles Nathan = new OtherProfiles("Nathan", 44, "Male", "IB", "Copenhagen");
            Nathan.PrintOtherProfiles();
            Console.WriteLine();

            OtherProfiles Natalie = new OtherProfiles("Natalie", 27, "Female", "Phycisian", "Bergen");
            Natalie.PrintOtherProfiles();
            Console.WriteLine();

            List<OtherProfiles> FriendsList = new List<OtherProfiles>();

            Console.WriteLine("Do you want to add Kate as friend?");
            if (Console.ReadLine().ToLower() == "yes")
                FriendsList.Add(Kate);

            Console.WriteLine("Do you want to add Marcus as friend?");
            if (Console.ReadLine().ToLower() == "yes")
                FriendsList.Add(Marcus);

            Console.WriteLine("Do you want to add Nathan as friend?");
            if (Console.ReadLine().ToLower() == "yes")
                FriendsList.Add(Nathan);

            Console.WriteLine("Do you want to add Natalie as friend?");
            if (Console.ReadLine().ToLower() == "yes")
                FriendsList.Add(Natalie);

            Console.WriteLine("Here's an overview of your updated Friendslist:");
            foreach (var friend in FriendsList)
            {
                friend.PrintOtherProfiles();
            }

            Console.WriteLine();

            Console.WriteLine("Would you like to remove someone from your friendslist?");
            bool RemoveFriend = false;
            if (Console.ReadLine().ToLower() == "yes")
            {
                RemoveFriend = true;
                while (RemoveFriend)
                {
                    Console.WriteLine("Submit the name of whom you'd like removed");

                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "Kate":
                            FriendsList.Remove(Kate);
                            break;

                        case "Marcus":
                            FriendsList.Remove(Marcus);
                            break;

                        case "Nathan":
                            FriendsList.Remove(Nathan);
                            break;

                        case "Natalie":
                            FriendsList.Remove(Natalie);
                            break;
                    }
                    Console.WriteLine("Do you want to remove another friend from the list?");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        RemoveFriend = true;
                    }
                    else
                    {
                        RemoveFriend = false;
                    }
                }

                while (!RemoveFriend)
                {
                    Console.WriteLine("Here's your updated friendslist:");

                    foreach (var friend in FriendsList)
                    {
                        friend.PrintOtherProfiles();
                    }
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Ok");
            }




        }
    }
}