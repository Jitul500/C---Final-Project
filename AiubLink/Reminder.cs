using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiubLink
{
    public class Reminder
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Reminder(DateTime date, string text)
        {
            Date = date;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()}: {Text}";
        }
    }
}
