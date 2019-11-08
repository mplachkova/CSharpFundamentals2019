using System;
using System.Collections.Generic;
using System.Linq;

namespace articles
{
    class articles
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] articleProperties = Console.ReadLine().Split(", ");
                string articleTitle = articleProperties[0];
                string articleContent = articleProperties[1];
                string articleAuthor = articleProperties[2];
                Article myArticle = new Article(articleProperties[0], articleProperties[1], articleProperties[2]);
                articleList.Add(myArticle);
            }
            string orderByArgument = Console.ReadLine();
            switch (orderByArgument)
            {
                case "title":
                    articleList = articleList.OrderBy(article => article.Title).ToList();
                    break;
                case "content":
                    articleList = articleList.OrderBy(article => article.Content).ToList();
                    break;
                case "author":
                    articleList = articleList.OrderBy(article => article.Author).ToList();
                    break;
            }
            foreach (Article element in articleList)
            {
                Console.WriteLine(element);
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}