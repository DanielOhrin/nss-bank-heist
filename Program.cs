using System;
using System.Collections.Generic;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Member teamMemberOne = new Member();

            Console.Write("Enter a name: ");
            teamMemberOne.Name = Console.ReadLine();

            Console.Write("Enter a skill level: ");
            teamMemberOne.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write("Enter a courage factor: ");
            teamMemberOne.CourageFactor = double.Parse(Console.ReadLine());

            List<Member> teamMembers = new List<Member> { teamMemberOne };

            // Loops until user enters an empty string for name
            while (true == true)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                // If name entered is an empty string, break out of loop and don't prompt for more info
                if (name == "")
                {
                    break;
                }

                // Create a new instance of Member class
                Member newTeamMember = new Member { Name = name };

                Console.Write("Enter a skill level: ");
                newTeamMember.SkillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter a courage factor: ");
                newTeamMember.CourageFactor = double.Parse(Console.ReadLine());

                teamMembers.Add(newTeamMember);
            }

            Console.WriteLine($"There are {teamMembers.Count} team members.");

            int difficulty = 100;
            int totalSkillLevel = 0;

            foreach (Member member in teamMembers)
            {
                totalSkillLevel += member.SkillLevel;
            }

            if (totalSkillLevel >= difficulty)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}