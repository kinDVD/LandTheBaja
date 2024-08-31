using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Astronaut
    {
        public string SuitColor { get; set; }
        public bool IsTraitor { get; set; }

        public Astronaut(string suitColor, bool isTraitor) 
        {
            SuitColor = suitColor;
            IsTraitor = isTraitor;
        }
    
    }
}
