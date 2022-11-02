using Crownhart_linkedlist;

// Sue Crownhart
// IT113
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: could not figure out how to sort it.
// And to be completely honest, I had help from stack overflow to delete a name properly
// and to add it properly. My brain was not making the connection from the demonstrations we did
// in class to calling it from the class and be continuing to add names even if I went back and did 
// something else. What it looked like it was doing was overwriting the previous nodes I added, which means
// the nodes were not getting added properly. I did figure out the searching method completely on my own.

Console.WriteLine("Begin creating a list of names? y/n");
string answer = Console.ReadLine().ToLower();

LinkedList MyList = new LinkedList();
while (answer != "n" && answer != "y")
{
    if (answer != "n" || answer != "y")
    {
        Console.WriteLine("Type a y for yes or n for n");
        answer = Console.ReadLine().ToLower();
    }
    if (answer != "n" || answer != "y")
    {
        break;
    }

}
if (answer == "n")
{
    Console.WriteLine("Good bye!");
    return;
}



while (answer == "y")
{
    MenuDisplay();
    Console.WriteLine("Please pick a number");
    string choice = Console.ReadLine();



    switch (choice)
    {
        case "1":
            string name = "";
            Console.WriteLine("Type a name");
            name = Console.ReadLine();
            MyList.Add(name);
            break;

        case "2":
            Console.WriteLine("Type the name you wish to delete");
            string delete = Console.ReadLine();
            MyList.delete(delete);
            break;
        case "3":
            Console.WriteLine("Type the name you wish to be found");
            string found = Console.ReadLine();
            MyList.search(found);
            break;
        case "4":
            MyList.Print();
            break;
        case "5":
            Console.WriteLine("Bye!");
            return;

        default:
            Console.WriteLine("Sorry.... you're not understood.");
            MenuDisplay();
            choice = Console.ReadLine();
            break;
    }

}






void MenuDisplay()
{
    Console.WriteLine("****************************");
    Console.WriteLine("*        1: Add            *");
    Console.WriteLine("*        2: Remove         *");
    Console.WriteLine("*        3: Search         *");
    Console.WriteLine("*        4: Print          *");
    Console.WriteLine("*        5: Exit           *");
    Console.WriteLine("****************************");
}
