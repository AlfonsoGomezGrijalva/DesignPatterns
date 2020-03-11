using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class TermPaper : Manuscript
    {
        public TermPaper(IFormatter formatter) : base(formatter)
        {
        }

        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public override StringBuilder Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(formatter.Format("Class", Class));
            sb.AppendLine(formatter.Format("Student", Student));
            sb.AppendLine(formatter.Format("Text", Text));
            sb.AppendLine(formatter.Format("References", References));
            return sb;
        }
    }
}
