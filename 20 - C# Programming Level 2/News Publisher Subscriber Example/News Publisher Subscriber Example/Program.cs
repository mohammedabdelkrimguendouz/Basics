using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Subscriber_Example
{
    public class NewsArticle
    {
        public string Title { get; }
        public string Content { get; }
        public NewsArticle(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public class NewsPublisher
    {
        public event EventHandler<NewsArticle> OnNewNewsPublished;
        public void PublishNews(string Title,string Content)
        {
            var Article=new NewsArticle(Title,Content);
            RaiseOnNewNewsPublished(Article);
        }
        protected virtual void RaiseOnNewNewsPublished(NewsArticle Article)
        {
            OnNewNewsPublished?.Invoke(this, Article);
        }
    }

    public class NewsSubscriber
    {
        public string Name { get; }
        public NewsSubscriber(string name)
        {
            Name = name;
        }
        public void Subscribe(NewsPublisher Publisher) 
        {
            Publisher.OnNewNewsPublished += HandleNewNews;
        }
        public void UnSubscribe(NewsPublisher Publisher)
        {
            Publisher.OnNewNewsPublished -= HandleNewNews;
        }
        public void HandleNewNews(object sender,NewsArticle Article)
        {
            Console.WriteLine($"\n\n{Name} received a new news article : ");
            Console.WriteLine($"Title = {Article.Title}");
            Console.WriteLine($"Content = {Article.Content}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher publisher = new NewsPublisher();
            NewsSubscriber subscriber1 = new NewsSubscriber("Subscriber 1");

            subscriber1.Subscribe(publisher);

            NewsSubscriber subscriber2 = new NewsSubscriber("Subscriber 2");
            subscriber2.Subscribe(publisher);

            publisher.PublishNews("Welcom 1", "Publish News 1  ");
            publisher.PublishNews("Welcom 2", "Publish News 2  ");

            subscriber1.UnSubscribe(publisher);
            publisher.PublishNews("Welcom 3", "Publish News 3  ");

            subscriber2.UnSubscribe(publisher);
            publisher.PublishNews("Welcom 4", "Publish News 4  ");

            Console.ReadKey();
        }
    }
}
