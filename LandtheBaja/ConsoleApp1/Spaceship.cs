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
        //public void - clue is group landing drill - traitors have 90% failure, non-traitors have 15% failure.
        public void landingDrill()
        {
            bool success = false;
            Random rnd1 = new Random();
            foreach (Astronaut c in Astronauts)
                
                if(c.IsTraitor == true)
                {
                    int roll = rnd1.Next(1, 50);
                    if (roll <= 5)
                    {
                        success = true;
                        if (roll == 1)
                        {
                            Console.WriteLine($"{c.SuitColor} called success from their station. You didn't see it.");
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} succeeded at their function.");
                        }
                    }
                    else
                    {
                        success = false;
                        if (roll >= 40)
                        {
                            Console.WriteLine($"{c.SuitColor} did not succeed at their function.");
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} calls failure from their station. You didn't see it.");
                        }
                    }
                }
                else
                {
                    int roll = rnd1.Next(1, 10);
                    if (roll <= 9)
                    {
                        success = true;
                        Console.WriteLine($"{c.SuitColor} succeeded at their function.");
                    }
                    else
                    {
                        success = false;
                        Console.WriteLine($"{c.SuitColor} calls failure from their station. You didn't see it.");
                    }
                }
        }

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

