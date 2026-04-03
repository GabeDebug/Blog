using System;
using Blog.Model;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class CreateTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("---------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagsScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel salva a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}