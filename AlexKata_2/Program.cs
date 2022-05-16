using System;
using AlexKata_2;


namespace AlexKata_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Create a couple of members");
            var member1 = Member.Factory.CreateWithRandomData();
            Console.WriteLine($"member1: {member1}");
            var member2 = Member.Factory.CreateWithRandomData();
            Console.WriteLine($"member2: {member2}");

            Console.WriteLine("\nCreate a 20 Hilton members");
            var HiltonMembers = MemberList.Factory.CreateWithRandomData(20);
            HiltonMembers.Sort();
            Console.WriteLine(HiltonMembers);

            Console.WriteLine("\nCreate a 20 Radisson members");
            var RadissonMembers = MemberList.Factory.CreateWithRandomData(20);
            RadissonMembers.Sort();
            Console.WriteLine(RadissonMembers);

            Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
            Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
            Console.WriteLine();
        }
    }
}