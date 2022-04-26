using Kata3_Inheritance;

//Notice all variables are of type IMember not IRadissonMember etc, But Benefits
//is written out correctly due to polyforfism
IMember myRadisson = RadissonMember.Factory.CreateWithRandomData();
IMember myHilton = HiltonMember.Factory.CreateWithRandomData();
IMember myScandic = ScandicMember.Factory.CreateWithRandomData();
Console.WriteLine(myRadisson);
Console.WriteLine(myHilton);
Console.WriteLine(myScandic);

//Notice that below will cause an NotImplementedException in Member.Benefits
IMember genericMember = Member.Factory.CreateWithRandomData();
//Console.WriteLine(genericMember);

Console.WriteLine();
var myList = MemberList.Factory.CreateWithRandomData(20);
Console.WriteLine(myList);
