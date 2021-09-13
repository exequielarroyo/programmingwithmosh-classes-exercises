using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var post = new StackOverflow("Hello","Nothing");
            while (true)
            {
                //stopwatch.Start();
                //Console.ReadLine();
                //stopwatch.Stop();
                //Console.WriteLine(stopwatch.GetResult);
                //Console.ReadLine();

                Console.WriteLine(post.Votes);
                post.UpVote();
                post.UpVote();
                post.DownVote();
                post.DownVote();
                post.DownVote();
                post.DownVote();
                Console.WriteLine("Title: {0}\nDescription: {1}\nDate created: {2}",post.Title, post.Description, post.DateCreated);
                
                Console.WriteLine(post.Votes);
                Console.ReadLine();
            }
        }
    }
}
