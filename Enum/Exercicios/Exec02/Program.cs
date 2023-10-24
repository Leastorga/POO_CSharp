using System;
using Exec02.Entities;

namespace Exec02 {
    class Program {
        static void Main(string[] args) {

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("How that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018/13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12
            );

            p1.AddComment(comment1);
            p1.AddComment(comment2);

            Comment c1 = new Comment("Good night");
            Comment c2 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Goodnight guys",
                "See you tomorrow",
                5
            );
            p2.AddComment(c1);
            p2.AddComment(c2);

        }
    }
}