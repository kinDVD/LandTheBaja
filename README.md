# Assessment 3a
This is the first game I have attempted to create in C#.

We had to create several classes and methods for a recent assessment. The project incorporated a list of astronauts, each with a suitcolor property and a boolean traitor property, and, after user input, if any of the astronauts on the list have a traitor property set to true, a landedSafely boolean is returned as false.

Here I built upon the project, randomizing the astronaut traitors with each playthrough. I created a console.Writeline to list each astronaut by index and suitcolor. 

User input removes astronauts from the list and decides when to land. After the landing sequence is initialized, the user is told whether or not all traitors were successfully removed and subsequently whether or not the spaceship landed. Then the game offers to loop back and start over.