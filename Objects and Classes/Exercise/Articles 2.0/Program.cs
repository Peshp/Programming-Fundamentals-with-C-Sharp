using System;
using System.Collections.Generic;

namespace FundC202
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> art = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                Article article = new Article(command[0], command[1], command[2]);
                art.Add(article);
            }

            string line = Console.ReadLine();

            foreach (Article article in art)
            {
                Console.WriteLine(article);
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
