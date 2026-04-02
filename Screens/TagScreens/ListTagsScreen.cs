using System;
using Blog.Model;
using Blog.Repositories;


namespace Blog.Screens.TagScreens
{
    public class ListTagScreen
    {
        public static void Load()
        {

        }
        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();

            foreach (var tag in tags)
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");
        }
    }
}