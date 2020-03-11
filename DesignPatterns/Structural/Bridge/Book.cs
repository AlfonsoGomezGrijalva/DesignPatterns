using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public override StringBuilder Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(formatter.Format("Title", Title));
            sb.AppendLine(formatter.Format("Author", Author));
            sb.AppendLine(formatter.Format("Text", Text));
            return sb;
        }
    }
}
