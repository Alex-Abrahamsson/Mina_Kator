using Kata2_IEquatable_IComparable_Factory;

Console.WriteLine("Create a couple of members");
var member1 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member1: {member1}");
var member2 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member2: {member2}");

Console.WriteLine("\nCreate a 20 Hilton members");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20); 
HiltonMembers.Sort();
Console.WriteLine($"HiltonMembers Gold Members: {HiltonMembers.NrOfMembers(IsGold)}");
Console.WriteLine($"HiltonMembers Silver Members: {HiltonMembers.NrOfMembers(IsSilver)}");
Console.WriteLine($"HiltonMembers Blue Members: {HiltonMembers.NrOfMembers(IsBlueAnd5Years)}");


Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine();

bool IsGold(IMember member) => member.Level == MemberLevel.Gold;
bool IsSilver(IMember member) => member.Level == MemberLevel.Silver;
bool IsBlueAnd5Years(IMember member)
{ 
    if (member.Level == MemberLevel.Blue)
    {
        var ts = DateTime.Now - member.Since;
        if (ts.Days >= 365 * 5)
            return true;
    }
    return false;
}
