using StaticLecture;
using ConsoleApp1;
bool runProgram = true;
int programCount = 0;
while (runProgram)
{
    Spaceship Baja = new Spaceship();
    string shipName = "Baja" + programCount;
    bool land = true;
    int jettison = 0;
    double mutiny = 0;
    List<Astronaut> jettisonedT = new List<Astronaut>();
    Baja.RandomTraitors();
    Console.WriteLine($"You drift over the earth in the {shipName}.\r\n" +
        "The Baja's resources won't last another day.\r\n" +
        "You have been democratically elected by the others to make the call.\r\n" +
        "You must begin entry and landing sequence soon,\r\n" +
        "but there are traitors aboard who mean to crash the ship.\r\n" +
        "Your only option is to the jettison the traitors, but who?\r\n" +
        "-Run landing drills to look for traitors.\r\n" +
        "-Jettison traitors.\r\n" +
        "-Or land.\r\n" +
        "Those are your only options.\r\n");
    Console.WriteLine("Press ENTER to continue.");
    Console.ReadLine();
    Console.Clear();

    while (land)
    {
        while (mutiny < 10)
        {
            Console.WriteLine("The room is tense.");
            Console.WriteLine("The astronauts who remain:");
            Baja.DisplayCrew();
            Baja.MutinyMeter(mutiny);
            Console.WriteLine("Would you like to:\r\n" +
                "1. jettison a crew member,\r\n" +
                "2. perform a landing drill,\r\n" +
                "3. ready to land?");
            int prep = Validator.GetIntRange();
            if (prep == 1)
            {
                Console.Clear();
                Baja.DisplayCrew();
                Console.WriteLine("ENTER A NUMBER TO REMOVE AN ASTRONAUT");
                int index = Validator.GetInputInt();
                Baja.RemoveAstronaut(index, jettisonedT);
                mutiny += 0.7 + (mutiny * 1.5);
                jettison++;
                Console.Clear();
            }
            else if (prep == 2)
            {
                Console.Clear();
                Console.WriteLine("You muster false enthusiasm and request an entry drill.");
                Baja.landingDrill();
                Console.WriteLine("Press ENTER to continue.");
                mutiny += 0.5 + (mutiny * 1.5);
                Console.ReadLine();
                Console.Clear();
            }
            else if (prep == 3)
            {
                Console.Clear();
                Console.WriteLine("Commence landing sequence? y/n");
                string landIt = Console.ReadLine();
                if (landIt == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.Clear();
        }
        if (mutiny > 3)
        {
            Console.WriteLine("The remaining astronauts grab you and force you into the airlock.");
            Console.WriteLine("The traitors won.");
            break;
        }
        bool crashLanding = Baja.LandSafely();
        if (crashLanding == false)
        {
            Console.WriteLine("Congrats! You jettisoned every traitor! The Baja landed safely.");
            break;
        }
        else
        {
            Console.WriteLine("Tragically the Baja blasted apart in the upper atmosphere. The traitors were successful.");
            break;
        }
    }
    Console.WriteLine($"You jettisoned {jettison} astronauts.");
    Console.WriteLine("The traitors were:");
    Baja.RevealTraitors(jettisonedT);
    Console.WriteLine("Would you like to start again? y/n");
    string again = Console.ReadLine();
    if (again == "y")
    {
        runProgram = true;
        programCount += 1;
        Console.Clear();
    }
    else
    {
        runProgram = false;
        Console.Clear();
    }
}



