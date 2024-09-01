using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Spaceship
    {
        public List<Astronaut> Astronauts { get; set; }
        public Spaceship()
        {
            //Grand Circus / Subsidiary of Dexian
            Astronauts = new List<Astronaut>();
            {
                Astronauts.Add(new Astronaut("Blue", false));
                Astronauts.Add(new Astronaut("Red", false));
                Astronauts.Add(new Astronaut("Orange", false));
                Astronauts.Add(new Astronaut("Green", false));
                Astronauts.Add(new Astronaut("Pink", false));
                Astronauts.Add(new Astronaut("Yellow", false));
                Astronauts.Add(new Astronaut("Black", false));
                Astronauts.Add(new Astronaut("White", false));
                Astronauts.Add(new Astronaut("Purple", false));
                Astronauts.Add(new Astronaut("Brown", false));
                //Green, Pink, Yellow, Black, White, Purple, Brown
            };
        }
        public void RandomTraitors()
        {
            for (int i = 0; i < 2; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(9);
                foreach(Astronaut c in Astronauts)
                {
                    if(Astronauts.IndexOf(c) == index)
                    {
                        c.IsTraitor = true;
                    }
                }

            }
        }
        public void 
        public void RemoveAstronaut(int index)
        {
            for (int i = 0; i < Astronauts.Count; i++)
            {
                if (i == index)
                {
                    Astronauts.Remove(Astronauts[i]);
                    break;
                }
            }
        }
        public bool LandSafely()
        {
            bool traitored = false;
            foreach (Astronaut c in Astronauts)
            {
                if (c.IsTraitor == true)
                {
                    traitored = true;
                    break;
                }
                else if (c.IsTraitor == false)
                {
                    traitored = false;
                }

            }
            return traitored;
        }
        public void DisplayCrew()
        {
            foreach(Astronaut c in Astronauts)
            {
                Console.WriteLine($"{Astronauts.IndexOf(c)}. {c.SuitColor}");
            }
        }
    }
}

