using MovieDatabase_Lab;
using System;
using System.Collections.Generic;
using System.Linq;

//Display correct movie

Console.WriteLine("Welcome to the Movie List Application!There are 10 movies in this list. What category are you interested in?");

var value = true;
do
{
    var moviesList = new List<Movie>
            {
                new Movie("Encanto", "animated"),
                new Movie("The Proud Family","animated"),
                new Movie("The GodFather",  "drama"),
                new Movie("A Bronx Tale", "drama"),
                new Movie("Get Out",  "horror"),
                new Movie("It", "horror"),
                new Movie("Black Panther", "scifi"),
                new Movie("The Wizard Of Oz", "scifi"),
                new Movie("Taken", "drama" ),
                new Movie("Mr. Brooks",  "drama"),
            };

    //input readline
    Console.WriteLine("Please choose between 'animated', 'drama', 'horror' and 'scifi'.");
    var categoryMovie = Console.ReadLine();
    if (categoryMovie != "animated" && categoryMovie != "drama" && categoryMovie != "horror" && categoryMovie != "scifi")
    {
        Console.WriteLine("Please choose one of the categories listed above");
        return;
    }

    else
    {
        var animatedMovies = moviesList.Where(x => x.GetCategory() == categoryMovie);
        foreach (var t in animatedMovies)
        {
            Console.WriteLine(t.GetTitle());
        }
        
    }
    Console.WriteLine("Would you like to continue? y/n");
    var answer = Console.ReadLine();

    if (answer == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thank you, bye!");
        break;
    }
}
while (value);
