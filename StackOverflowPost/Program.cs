using System;
using System.Collections.Generic;

namespace StackOverflowPost
{
    internal partial class Program
    {
        static readonly List<Post> Posts = new List<Post>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Create Post (y/n) or (or type 'end' to quit)");
                var input = Console.ReadLine();
                Console.WriteLine("\n");
                switch (input)
                {
                    case "y":
                        Console.WriteLine("Enter post title");
                        var inputTitle = Console.ReadLine();
                        Console.WriteLine("Enter post description");
                        var inputDesc = Console.ReadLine();
                        var post = new Post(inputTitle, inputDesc);
                        Posts.Add(post);
                        break;
                    case "n":
                        break;
                    case "end":
                        return;
                    default:
                        Console.WriteLine("Wrong input! \n");
                        continue;
                }
                if (input.ToLower() != "y")
                    break;
            }
            while (true)
            {
                Console.WriteLine("UpVote or DownVote post | Choose post based on title and select action! \n");
                foreach (var p in Posts)
                {
                    p.PrintPost();
                }
                Console.WriteLine("Enter post 'title' or type 'end' to quit");
                var inputTitle = Console.ReadLine();
                if (inputTitle.ToLower() == "end")
                {
                    foreach (var p in Posts)
                    {
                        p.PrintPost();
                    }
                    break;
                }
                var selectedPost = Posts.Find(p => p.Title == inputTitle);
                if (selectedPost != null)
                {
                    Console.WriteLine($"Selected Post: {selectedPost.Title} - {selectedPost.Description}");
                    while (true)
                    {
                        Console.WriteLine("Choose action: 'up' (UpVote), 'down' (DownVote)");
                        var inputVote = Console.ReadLine().ToLower();
                        switch (inputVote)
                        {
                            case "up":
                                selectedPost.UpVote();
                                selectedPost.PrintPost();
                                break;
                            case "down":
                                selectedPost.DownVote();
                                selectedPost.PrintPost();
                                break;
                            default:
                                Console.WriteLine("Wrong input!\n");
                                continue;
                        }
                        Console.WriteLine("Type 'posts' to see post list (or any key to continue editing the current post )");
                        var inputNewPost = Console.ReadLine();
                        if (inputNewPost.ToLower() == "posts")
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Post doesn't exist");
                }
            }
        }
    }
}
