namespace StackOverflowPost
{
    internal partial class Program
    {
        public class Post
        {
            public string Title { get; private set; }
            public string Description { get; private set; }
            public DateTime DateCreated { get; private set; }
            public int Votes { get; private set; }

            public Post(string title, string description)
            {
                this.Title = title;
                this.Description = description;
                this.DateCreated = DateTime.Now;
                PrintPost();
            }
            public void UpVote()
            {
                this.Votes++;
            }
            public void DownVote()
            {
                this.Votes--;
            }
            public void PrintPost()
            {
                Console.WriteLine($"{this.Title} - {this.Description} - {this.DateCreated} - {this.Votes}");
            }
        }
    }
}
