using Curse.Entities;

namespace Curse;

internal class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("Have a nice trip! ");
        Comment c2 = new Comment("Wow that's awesome! ");

        Post post = new Post(DateTime.Parse("21/06/2018 13:05:44"),
            "Triveling to New Zealand",
            "I'm going to visit this wonderful country!",
            12);
        post .Comments.Add(c1);
        post .Comments.Add(c2);


        Comment c3 = new Comment("Good night");
        Comment c4 = new Comment("May the Force be with you");

        Post post1 = new Post(DateTime.Parse("28/07/2018 23:14:19"),
            "Good night guys",
            "See you tomorrow",
            12);
        post1.Comments.Add(c3);
        post1.Comments.Add(c4);

        Console.WriteLine(post);
        Console.WriteLine(post1);
    }
}
