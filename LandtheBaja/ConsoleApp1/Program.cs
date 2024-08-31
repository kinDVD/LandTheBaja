using StaticLecture;
using ConsoleApp1;
bool runProgram = true;
while (runProgram)
{
    Spaceship Baja = new Spaceship();
    bool land = true;
    while (land)
    {
        Baja.RandomTraitors();
        Console.WriteLine("The room is tense.");
        Console.WriteLine("The astronauts who remain wear");
        Baja.DisplayCrew();
        Console.WriteLine("colored suits.");
        Console.WriteLine("ENTER A NUMBER TO REMOVE AN ASTRONAUT");
        int index = Validator.GetInputInt();
        Baja.RemoveAstronaut(index);
        Console.WriteLine("Are you prepared to land? y/n");
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
    bool crashLanding = Baja.LandSafely();
    if (crashLanding == false)
    {
        Console.WriteLine("Congrats! You jettisoned every traitor! The Baja landed safely.");
    }
    else
    {
        Console.WriteLine("Tragically the Baja blasted apart in the upper atmosphere. The traitors were successful.");
    }
    Console.WriteLine("Would you like to start again? y/n");
    string again = Console.ReadLine();
    if (again == "y")
    {
        runProgram = true;
    }
    else
    {
        runProgram = false;
    }
}



