using System;
using Blog.Model;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagsScreen
    {
        public static void Load(int id)
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma Tag:");
            Console.WriteLine("---------------");
            Console.Write("Id: ");
            var id1 = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id1),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagsScreen.Load();
        }
        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag Atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel Atualizar a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}