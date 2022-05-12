using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexKata_2
{
    public enum MemberLevel {MIN, Platinum, Gold, Silver, Blue, MAX}
    public interface IMember: IEquatable<IMember>, IComparable<IMember>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level {get; set;}
        public DateTime Since { get; set; }
    }
 }
