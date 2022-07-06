using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC201
{
    public class Program
    {
        static void Main()
        {
            string[] art = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            var article = new Article(art[0], art[1], art[2]);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string cm = command[0];
                string arg = command[1];

                switch (cm)
                {
                    case "Edit":
                        article.Edit(arg);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(arg);
                        break;
                    case "Rename":
                        article.Rename(arg);
                        break;
                }
            }

            Console.WriteLine(article);
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string rename)
        {
            Title = rename;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
