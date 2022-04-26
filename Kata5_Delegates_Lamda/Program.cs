using Kata5_Delegates_Lamda;

Console.WriteLine("Create a couple of members");
var member1 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member1: {member1}");
var member2 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member2: {member2}");

Console.WriteLine("\nCreate a 20 Hilton members");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20, HelloHilton); 
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("\nCreate a 20 Radisson members");
var RadissonMembers = MemberList.Factory.CreateWithRandomData(20, HelloRadisson);
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();

Console.WriteLine("\nCreate a 10 Scandic members");
int nrBlue = 0;
var ScandicMembers = MemberList.Factory.CreateWithRandomData(10, m =>
{
    if (m.Level == MemberLevel.Blue)
        nrBlue++;
});
Console.WriteLine(ScandicMembers);
Console.WriteLine($"Nr of Blue members: {nrBlue}");


#region Delegate Methods
static void HelloHilton(IMember member)
{
    Console.WriteLine($"Warm Hilton welcome {member.FirstName}!!");
    if (member.Level == MemberLevel.Platinum)
    {
        Console.WriteLine("Wow!");
    }
}
static void HelloRadisson(IMember member)
{
    Console.WriteLine($"Warm Radisson welcome {member.FirstName}!!");
}
#endregion

