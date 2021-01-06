using System;
using AplicativoSocialStringBuilder.Entities;

namespace AplicativoSocialStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip buddy!");
            Comment c2 = new Comment("That's Awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2020"), "Traveling to Brazil with my girlfriend", "Eating as much as we can", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("I like chopin");
            Comment c4 = new Comment("Bee gees songs");

            Post p2 = new Post(DateTime.Parse("21/03/2019"), "Looking for musics", "Anybody could help me find new old songs?", 9);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
