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
                Astronauts.Add(new Astronaut("Blue", false, 0, 0));
                Astronauts.Add(new Astronaut("Red", false, 0, 0));
                Astronauts.Add(new Astronaut("Orange", false, 0, 0));
                Astronauts.Add(new Astronaut("Green", false, 0, 0));
                Astronauts.Add(new Astronaut("Pink", false, 0, 0));
                Astronauts.Add(new Astronaut("Yellow", false, 0, 0));
                Astronauts.Add(new Astronaut("Black", false, 0, 0));
                Astronauts.Add(new Astronaut("White", false, 0, 0));
                Astronauts.Add(new Astronaut("Purple", false, 0, 0));
                Astronauts.Add(new Astronaut("Brown", false, 0, 0));
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
            Random rnd1 = new Random();
            foreach (Astronaut c in Astronauts)
                
                if(c.IsTraitor == true)
                {
                    int roll = rnd1.Next(1, 50);
                    if (roll >= 35)
                    {
                        if (roll > 45)
                        {
                            Console.WriteLine($"{c.SuitColor} succeeded at their function. Drill Success++");
                            c.DrillSuccess++;
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} called success from their station. You didn't see it. Drill Clue++");
                            c.DrillClue++;
                        }
                    }
                    else
                    {
                        if (roll <= 15)
                        {
                            Console.WriteLine($"{c.SuitColor} did not succeed at their function.");
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} called failure from their station. You didn't see it.");
                        }
                    }
                }
                else
                {
                    int roll = rnd1.Next(1, 50);
                    if (roll <= 35)
                    {
                        if (roll <= 20)
                        {
                            Console.WriteLine($"{c.SuitColor} succeeded at their function. Drill Success++");
                            c.DrillSuccess++;
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} called success from their station. You didn't see it. Drill Clue++");
                            c.DrillClue++;
                        }
                    }
                    else
                    {
                        if (roll <= 45)
                        {
                            Console.WriteLine($"{c.SuitColor} did not succeed at their function.");
                        }
                        else
                        {
                            Console.WriteLine($"{c.SuitColor} called failure from their station. You didn't see it.");
                        }
                    }
                }
        }

        public List<Astronaut> RemoveAstronaut(int index, List<Astronaut> jettisonedT)
        {
            for (int i = 0; i < Astronauts.Count; i++)
            {
                if (i == index)
                {
                    if (Astronauts[i].IsTraitor == true)
                    {
                        jettisonedT.Add(Astronauts[i]);
                    }
                    Astronauts.Remove(Astronauts[i]);
                    break;
                }
            }
            return jettisonedT;
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

            Console.WriteLine("# | Suit Color: | DS | DC");
            foreach (Astronaut c in Astronauts)
            {
                Console.WriteLine("{0,1} {1,10} {2,5} {3,5}", $"{Astronauts.IndexOf(c)}.", $"{c.SuitColor}", $"{c.DrillSuccess}", $"{c.DrillClue}");
            }
            Console.WriteLine("DS: Drill Success | DC: Drill Clue (i.e. unconfirmed success)");
        }
        public void MutinyMeter(double mutiny)
        {
            if (mutiny == 0)
            {
                Console.WriteLine("Chance of mutiny: 0%");
            }
            else if (mutiny <= 1)
            {
                Console.WriteLine("Chance of mutiny: >0%");
            }
            else if (mutiny <= 2)
            {
                Console.WriteLine("Chance of mutiny: 20%");
            }
            else if (mutiny <= 3)
            {
                Console.WriteLine("Chance of mutiny: 30%");
            }
            else if (mutiny <= 4)
            {
                Console.WriteLine("Chance of mutiny: 40%");
            }
            else if (mutiny <= 5)
            {
                Console.WriteLine("Chance of mutiny: 50%");
            }
            else if (mutiny <= 6)
            {
                Console.WriteLine("Chance of mutiny: 60%");
            }
            else if (mutiny <= 7)
            {
                Console.WriteLine("Chance of mutiny: 70%");
            }
            else if (mutiny <= 8)
            {
                Console.WriteLine("Chance of mutiny: 80%");
            }
            else if (mutiny <= 9)
            {
                Console.WriteLine("Chance of mutiny: 90%");
            }
            else if (mutiny < 10)
            {
                Console.WriteLine("Chance of mutiny: <100%");
            }
        }
        public void RevealTraitors(List<Astronaut>jettisonedT)
        {
            foreach (Astronaut a in Astronauts)
            {
                if (a.IsTraitor == true)
                {
                    Console.WriteLine($"{a.SuitColor}");
                }
            }
            foreach (Astronaut a in jettisonedT) 
            {
                Console.WriteLine($"{a.SuitColor}");
            }

        }
    }
}

