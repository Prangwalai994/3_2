using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_String3_2.Fundamentals
{
    class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return "<strong></strong>";
            return $"<strong>{content}<strong>";
        }
    }
}
