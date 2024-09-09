using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int DrillSuccess { get; set; }
        public int DrillClue { get; set; }

        public Astronaut(string suitColor, bool isTraitor, int drillSuccess, int drillClue) 
        {
            SuitColor = suitColor;
            IsTraitor = isTraitor;
            DrillSuccess = drillSuccess;
            DrillClue = drillClue;
        }


    }
}
