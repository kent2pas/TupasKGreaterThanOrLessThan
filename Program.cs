//Kent Tupas
//10/18/2022
//mini challenge 4
//update and upload to github
//

string input;

Console.Clear();
Console.WriteLine("____________________________________________________________");
Console.WriteLine("Greetings");
Console.WriteLine("let's play a game yes or no");
input = Console.ReadLine();
Console.WriteLine("");
while(input != "no"){
    Console.WriteLine("Pick two numbers");
    int numberone = Convert.ToInt32(Console.ReadLine());
    int numbertwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Great Picks ");
    Console.WriteLine("");
    if(numberone > numbertwo){
        Console.WriteLine($"{numberone} greater than {numbertwo}");
    }
    else if(numberone < numbertwo){
        Console.WriteLine($"{numberone} less than {numbertwo}");
    }
    else if(numberone == numbertwo){
        Console.WriteLine($"{numberone} equal to {numbertwo}");
    }
    Console.WriteLine("");
    Console.WriteLine("Want to play again yes or no");
    input = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Have a nice day!!");
    Console.WriteLine("____________________________________________________________");
}
    
     
