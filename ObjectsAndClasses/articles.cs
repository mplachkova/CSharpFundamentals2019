using System;

namespace articles
{
    class articles
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int numberOfCommands = int.Parse(Console.ReadLine());
            Article myArticle = new Article(input[0], input[1], input[2]);
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] instructions = Console.ReadLine().Split(": ");
                string command = instructions[0];
                string newData = instructions[1];
                switch(command)
                {
                    case "Edit":
                        myArticle.Edit(newData);
                        break;
                    case "ChangeAuthor":
                        myArticle.ChangeAuthor(newData);
                        break;
                    case "Rename":
                        myArticle.Rename(newData);
                        break;
                }
            }
            Console.WriteLine(myArticle.ToString());
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

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}