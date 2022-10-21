//Elizar Garcia
//10-18-22
//Minie challenge #3 "Asking Questions"
//This is a console project that will ask our user their name and what time they woke up.

Console.Clear();

string reply ="";
string reply2 ="";
string answer = "";
string stop ="";
int i = 0;
bool input1 = true;
bool input2 = true;

while(stop != "end")
{
    Console.WriteLine("Good Morning, What is your name?");
    reply = Console.ReadLine();
       input1 =Int32.TryParse(reply, out i);
    if(input1 ==true)
    {Console.WriteLine("I doubt that is your name.");

    }else{
        Console.WriteLine($"Nice to meet you {reply}, what time did you wake up? Please enter as millitary time -0000-. ");
        reply2 = Console.ReadLine();
        input2 =Int32.TryParse(reply2, out i);
       if(input2 == true)
        {Console.WriteLine($"Did you really wake up at {reply2}? Thats so early! ");
        }else{
            Console.WriteLine("Please enter as format provided.");
        }
    }
    Console.WriteLine("Type end to stop or press enter to start over.");
    answer = Console.ReadLine().ToLower();
    }