using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> Members { get; set; }
        public int Gold 
        {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }

                return totalGold;
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public Group()
        {
            Members = new List<IParty>();
        }

        public string Stats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var member in Members)
            {
                sb.AppendLine(member.Stats());
            }

            return sb.ToString().Trim();
        }
    }
}
