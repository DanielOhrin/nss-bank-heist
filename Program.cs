using System;

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

            Console.WriteLine($@"Team Member One:
            Name: {teamMemberOne.Name}
            Skill Level: {teamMemberOne.SkillLevel}
            Courage Factor: {teamMemberOne.CourageFactor}");

        }
    }
}
