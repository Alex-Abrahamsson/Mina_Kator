using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3_Inheritance
{
    internal class RadissonMember :Member, IRadissonMember
    {
        public override string[] Benefits { get; set; }
     
        #region Class Factory for creating an instance filled with Random data
        public new static class Factory
        {
            public static Member CreateWithRandomData()
            {
                var Benefits = "R:Free breakfast, R:Late checkin, R:One free drink in the bar".Split(',');
                var member = Member.Factory.CreateWithRandomData();
                var radissonMember = new RadissonMember
                {
                    FirstName = member.FirstName,
                    LastName = member.LastName,
                    Level = member.Level,
                    Since = member.Since,
                    Benefits = Benefits
                };

                return radissonMember; 
            }
        }
        #endregion
    }
}
