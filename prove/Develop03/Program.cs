using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureApp.Run();
    }
}

 // I have created 4 class that the program.cs will be able to reference in order the scripture app to work.
//The ScriptureApp class is responsible for running the main logic of the program.
//It orchestrates the process of selecting a random scripture, displaying it, and hiding words until the user decides to quit or all words are hidden. I made it to use the library and the scripture class to manage the the details of the scriptures.
//The ScriptureLibrary class is a container for a collection of scriptures. I can put random scriptures in this class that the user can play with. 
//With all other classes that I have created follow the principles of encapsulation