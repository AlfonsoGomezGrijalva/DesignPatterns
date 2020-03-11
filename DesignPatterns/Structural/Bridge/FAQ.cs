using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class FAQ : Manuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public override StringBuilder Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(formatter.Format("Tittle", Title));

            foreach (var question in Questions)
            {
                sb.AppendLine(formatter.Format("    Question", question.Key));
                sb.AppendLine(formatter.Format("    Answer", question.Value));
            }

            return sb;
        }
    }
}
